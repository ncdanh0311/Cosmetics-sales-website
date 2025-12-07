using System.Web.Mvc;
using project_mvc.Models;

namespace project_mvc.Controllers
{
    public class ChatBotApiController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Ask(ChatBotRequest request)
        {
            var question = request?.Question ?? Request?["question"];
            var result = ChatBotLibrary.GetAnswer(question);

            return Json(new
            {
                answer = result.Answer,
                matched = result.Matched
            }, JsonRequestBehavior.AllowGet);
        }
    }
}
