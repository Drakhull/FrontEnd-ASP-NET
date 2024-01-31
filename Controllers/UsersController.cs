using Microsoft.AspNetCore.Mvc;
using ModelsJava;
using Newtonsoft.Json;
using System.Text;

namespace Telessaude.Controllers
{
    public class UsersController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:8080")
            };

            var response = await client.GetAsync("users");
            response.EnsureSuccessStatusCode(); // Ensure success status code

            var content = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<User[]>(content);

            return View(users);
        }
        public async Task<IActionResult> Detail(String id)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:8080")
            };

            var response = await client.GetAsync($"users/{id}");
            response.EnsureSuccessStatusCode(); // Ensure success status code

            var content = await response.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<User>(content);

            return View(user);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateConfirmation(User user)
        {
            // Lógica para enviar os dados para a API Java
            // Utilize HttpClient para fazer a requisição POST
            // Certifique-se de tratar os casos de sucesso e falha adequadamente

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:8080")
            };

            var serializedUser = JsonConvert.SerializeObject(user);
            var content = new StringContent(serializedUser, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("users", content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }
        }
        public IActionResult DeleteConfirmation(String id, String name)
        {
            // Passe ambos os parâmetros para a view
            ViewData["UserId"] = id;
            ViewData["UserName"] = name;

            return View();
        }


        public async Task<IActionResult> Deleted(String id)
        {

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:8080")
            };
            var response = await client.DeleteAsync($"users/{id}");
            response.EnsureSuccessStatusCode();
            return View();
        }
    }
}
