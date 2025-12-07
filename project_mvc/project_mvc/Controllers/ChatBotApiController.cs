using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Hosting;
using System.Web.Mvc;

namespace project_mvc.Controllers
{
    public class ChatBotApiController : Controller
    {
        private static readonly Lazy<ChatBotLibrary> KnowledgeBase = new Lazy<ChatBotLibrary>(LoadLibrary);

        [HttpPost]
        public ActionResult Ask(ChatBotRequest request)
        {
            var incoming = request?.Message ?? request?.Question ?? string.Empty;
            var message = incoming.Trim();

            var library = KnowledgeBase.Value;
            var response = library.DefaultAnswer;
            List<string> matchedKeywords = null;

            if (!string.IsNullOrEmpty(message))
            {
                var lower = message.ToLowerInvariant();
                var matched = library.Intents.FirstOrDefault(intent =>
                    intent.Keywords.Any(keyword => lower.Contains(keyword)));

                if (matched != null)
                {
                    response = matched.Answer;
                    matchedKeywords = matched.Keywords;
                }
            }

            return Json(new
            {
                answer = response,
                matchedKeywords
            }, JsonRequestBehavior.AllowGet);
        }

        private static ChatBotLibrary LoadLibrary()
        {
            var defaultAnswer = "Mình đã ghi nhận câu hỏi và sẽ hỗ trợ nhanh nhất. Bạn có thể mô tả rõ hơn về da, nhu cầu hoặc mã đơn để mình tư vấn chi tiết.";
            var intents = new List<ChatBotIntent>();

            var viewPath = HostingEnvironment.MapPath("~/Views/Shared/View.cshtml");
            if (string.IsNullOrEmpty(viewPath) || !System.IO.File.Exists(viewPath))
            {
                return new ChatBotLibrary
                {
                    DefaultAnswer = defaultAnswer,
                    Intents = intents
                };
            }

            var content = System.IO.File.ReadAllText(viewPath);

            var defaultMatch = Regex.Match(content, @"const\s+defaultAnswer\s*=\s*\"(.*?)\";", RegexOptions.Singleline);
            if (defaultMatch.Success)
            {
                defaultAnswer = defaultMatch.Groups[1].Value;
            }

            var start = content.IndexOf("const fallbackAnswers = [", StringComparison.Ordinal);
            if (start >= 0)
            {
                var startBracket = content.IndexOf('[', start);
                var endBracket = content.IndexOf("];", startBracket, StringComparison.Ordinal);
                if (startBracket > -1 && endBracket > startBracket)
                {
                    var block = content.Substring(startBracket, endBracket - startBracket);
                    var itemRegex = new Regex(@"keywords:\s*\[(.*?)\]\s*,\s*answer:\s*\"(.*?)\"", RegexOptions.Singleline);
                    var keywordRegex = new Regex("\"([^\"]+)\"");

                    foreach (Match match in itemRegex.Matches(block))
                    {
                        var keywordsBlock = match.Groups[1].Value;
                        var keywords = keywordRegex
                            .Matches(keywordsBlock)
                            .Cast<Match>()
                            .Select(m => m.Groups[1].Value.ToLowerInvariant())
                            .Distinct()
                            .ToList();

                        var answer = match.Groups[2].Value;

                        if (keywords.Count > 0 && !string.IsNullOrWhiteSpace(answer))
                        {
                            intents.Add(new ChatBotIntent
                            {
                                Keywords = keywords,
                                Answer = answer
                            });
                        }
                    }
                }
            }

            return new ChatBotLibrary
            {
                DefaultAnswer = defaultAnswer,
                Intents = intents
            };
        }
    }

    public class ChatBotIntent
    {
        public List<string> Keywords { get; set; }

        public string Answer { get; set; }
    }

    public class ChatBotLibrary
    {
        public string DefaultAnswer { get; set; }

        public List<ChatBotIntent> Intents { get; set; }
    }

    public class ChatBotRequest
    {
        public string Message { get; set; }

        public string Question { get; set; }
    }
}
