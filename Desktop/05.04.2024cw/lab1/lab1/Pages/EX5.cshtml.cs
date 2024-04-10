using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab1.Pages
{
    public class EX5Model : PageModel
    {
        public bool AfterLoad { get; set; } = false;
        public Info Info { get; set; } = new Info();
        public void OnPost(string nameInput, string phoneInput, string messageInput)
        {
            AfterLoad = true;
            Info.Name = nameInput;
            Info.Phone = phoneInput;
            Info.Message = messageInput;
        }
    }
    public class Info
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
    }
}