using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab1.Pages
{
    public class EX3Model : PageModel
    {
        public bool Answer {  get; private set; }
        public bool AfterLoaded { get; private set; } = false;  
        private string login = "login";
        private string password = "password";
        public void OnPost(string loginInput, string passwordInput)
        {
            AfterLoaded = true;
            if(login == loginInput && password == passwordInput)
            {
                Answer = true;
            }
            else
            {
                Answer = false;
            }
        }
    }
}
