using System.Web.Mvc;
using project_mvc.Models;

namespace project_mvc.Controllers
{
    [RoutePrefix("api/chatbot")]
    public class ChatBotApiController : Controller
    {
        [HttpPost]
        [Route("ask")]
        [ValidateInput(false)]
        public JsonResult Ask(ChatBotRequest request)
        {
            var question = (request?.Message ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(question))
            {
                return Json(new
                {
                    success = false,
                    message = "Câu hỏi không được để trống."
                }, JsonRequestBehavior.AllowGet);
            }

            var result = ChatBotLibrary.GetAnswer(question);

            return Json(new
            {
                success = true,
                answer = result.Answer,
                matched = result.Matched
            }, JsonRequestBehavior.AllowGet);
        }
    }
}
