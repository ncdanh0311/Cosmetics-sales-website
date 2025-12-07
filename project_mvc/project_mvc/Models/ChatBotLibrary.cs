using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using Newtonsoft.Json;

namespace project_mvc.Models
{
    public class ChatBotEntry
    {
        public List<string> Keywords { get; set; } = new List<string>();
        public string Answer { get; set; }
    }

    public class ChatBotResult
    {
        public string Answer { get; set; }
        public bool Matched { get; set; }
    }

    public static class ChatBotLibrary
    {
        private const string DefaultAnswer = "Mình đã ghi nhận câu hỏi và sẽ hỗ trợ nhanh nhất. Bạn có thể mô tả rõ hơn về da, nhu cầu hoặc mã đơn để mình tư vấn chi tiết.";

        private static readonly Lazy<IReadOnlyList<ChatBotEntry>> Library = new Lazy<IReadOnlyList<ChatBotEntry>>(LoadLibrary, true);

        public static ChatBotResult GetAnswer(string question)
        {
            var normalized = (question ?? string.Empty).ToLowerInvariant();
            foreach (var entry in Library.Value)
            {
                if (entry?.Keywords == null)
                {
                    continue;
                }

                if (entry.Keywords.Any(keyword => !string.IsNullOrWhiteSpace(keyword) && normalized.Contains(keyword.ToLowerInvariant())))
                {
                    return new ChatBotResult
                    {
                        Answer = entry.Answer,
                        Matched = true
                    };
                }
            }

            return new ChatBotResult
            {
                Answer = DefaultAnswer,
                Matched = false
            };
        }

        private static IReadOnlyList<ChatBotEntry> LoadLibrary()
        {
            try
            {
                var path = HostingEnvironment.MapPath("~/App_Data/chatbot-data.json");
                if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
                {
                    var baseDirectory = AppDomain.CurrentDomain.BaseDirectory ?? string.Empty;
                    path = Path.Combine(baseDirectory, "App_Data", "chatbot-data.json");

                    if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
                    {
                        return Array.Empty<ChatBotEntry>();
                    }
                }

                var raw = File.ReadAllText(path);
                var data = JsonConvert.DeserializeObject<List<ChatBotEntry>>(raw);
                return data ?? new List<ChatBotEntry>();
            }
            catch
            {
                return Array.Empty<ChatBotEntry>();
            }
        }
    }
}
