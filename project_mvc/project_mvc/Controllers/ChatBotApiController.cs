using System;
using System.Linq;
using System.Web.Mvc;
using project_mvc.Models;

namespace project_mvc.Controllers
{
    public class ChatBotApiController : Controller
    {
        [HttpPost]
        public JsonResult Ask(ChatBotRequest request)
        {
            var question = (request?.Message ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(question))
            {
                return Json(new { success = false, message = "Câu hỏi không được để trống." });
            }

            var normalized = question.ToLowerInvariant();
            var match = ChatBotTrainingData.Library.FirstOrDefault(item =>
                item.Keywords.Any(keyword => normalized.Contains(keyword.ToLowerInvariant())));

            var answer = match?.Answer ?? ChatBotTrainingData.DefaultAnswer;
            return Json(new { success = true, answer });
        }
    }

    public class ChatBotRequest
    {
        public string Message { get; set; }
    }
}
