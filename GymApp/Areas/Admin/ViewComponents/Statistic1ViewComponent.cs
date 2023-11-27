using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Spreadsheet;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System.Security.Policy;


namespace GymApp.Areas.Admin.ViewComponents
{
    public class Statistic1ViewComponent : ViewComponent
    {
        private IBranchService _branchService;
        private IContactService _contactService;
        private IUserService _userService;
        public Statistic1ViewComponent(IBranchService branchService, IContactService contactService, IUserService userService)
        {
            _branchService = branchService;
            _contactService = contactService;
            _userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.branchNum = _branchService.GetAll().Count;
            ViewBag.contactNum = _contactService.GetAll().Count;
            ViewBag.memberNum = _userService.GetAll().Count;

            var apiKey = "bbb85d5f36770c209b030ecdcc46d636";
            var url = "https://api.openweathermap.org/data/2.5/weather?q=İstanbul&units=metric&appid=" + apiKey;
            using var client = new HttpClient();
            //client.BaseAddress = new Uri(url);
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
            // Get data response
            var response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body
                var result = response.Content
                    .ReadAsStringAsync().Result;

                //dynamic allText = JsonConvert.DeserializeObject(result);
                //Console.WriteLine(content.main.temp);

                var content = JObject.Parse(result);
              

                ViewBag.weather = content["main"]["temp"];

            }

            

            return View();
        }

    }
}
