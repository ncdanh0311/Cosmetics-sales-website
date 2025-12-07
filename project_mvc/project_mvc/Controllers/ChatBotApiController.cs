using System.IO;
using System.Web.Mvc;
using Newtonsoft.Json;
using project_mvc.Models;

namespace project_mvc.Controllers
{
    [RoutePrefix("api/chatbot")]
    public class ChatBotApiController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [Route("ask")]
        public JsonResult Ask()
        {
            var question = ExtractQuestion(Request);
            var result = ChatBotLibrary.GetAnswer(question);

            return Json(new
            {
                answer = result.Answer,
                matched = result.Matched
            }, JsonRequestBehavior.AllowGet);
        }

        private static string ExtractQuestion(HttpRequestBase request)
        {
            if (request == null)
            {
                return null;
            }

            var formQuestion = request["question"];
            if (!string.IsNullOrWhiteSpace(formQuestion))
            {
                return formQuestion;
            }

            try
            {
                request.InputStream.Position = 0;
                using (var reader = new StreamReader(request.InputStream))
                {
                    var rawBody = reader.ReadToEnd();
                    if (string.IsNullOrWhiteSpace(rawBody))
                    {
                        return null;
                    }

                    var model = JsonConvert.DeserializeObject<ChatBotRequest>(rawBody);
                    return model?.Question;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
