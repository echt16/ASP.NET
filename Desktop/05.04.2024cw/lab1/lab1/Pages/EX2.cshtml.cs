using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab1.Pages
{
    public class EX2Model : PageModel
    {
        public List<string> Countries = new List<string>
        {
        "USA", "Canada", "UK", "France", "Germany", "Italy", "Australia", "Japan", "China", "India"
        };

        public List<string> FilteredCountries { get; set; } = new List<string>();
        public string SearchInput { get; set; } = "";

        public void OnPost(string searchInput)
        {
            if (!string.IsNullOrWhiteSpace(searchInput))
            {
                FilteredCountries = Countries.Where(country => country.ToLower().Contains(searchInput.ToLower())).ToList();
                SearchInput = searchInput;
            }
            else
            {
                FilteredCountries = Countries;
                SearchInput = "";
            }
        }
    }
}
