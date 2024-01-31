using Newtonsoft.Json;
using ModelsJava;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace Telessaude
{
    public class Program
    {
        // public static void Main(string[] args) old
        public static async Task Main(string[] args)
        {
            HttpClient client = new()
            {
                BaseAddress = new Uri("http://localhost:8080")
            };

           var response = await client.GetAsync("users");
           var content = await response.Content.ReadAsStringAsync();
           var users = JsonConvert.DeserializeObject<User[]>(content);

            foreach(var user in users)
            {

               // Console.WriteLine(user.Name);
               // Console.WriteLine(user.Cpf);
            }

            // old end

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}