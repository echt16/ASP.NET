using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace hw1.Pages
{
    public class EX1Model : PageModel
    {
        public bool Subscribed {  get; set; } = false;
        public void OnPost(string subscribeInput)
        {
            Subscribed = subscribeInput == "Subscribe" ? true : false;
        }
    }
}
