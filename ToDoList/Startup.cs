// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.AspNetCore.Http;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.DependencyInjection;

// namespace ToDoList
// {
//   public class Startup
//   {
//     public Startup(IWebHostEnvironment env)
//     {
//       var builder = new ConfigurationBuilder()
//           .SetBasePath(env.ContentRootPath)
//           .AddEnvironmentVariables();
//       Configuration = builder.Build();
//     }

//     public IConfigurationRoot Configuration { get; }

//     public void ConfigureServices(IServiceCollection services)
//     {
//       services.AddMvc();
//     }

//     public void Configure(IApplicationBuilder app)
//     {
//       app.UseDeveloperExceptionPage();
//       app.UseRouting();

//       app.UseEndpoints(routes =>
//       {
//         routes.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
//       });

//       app.UseStaticFiles();
      
//       app.Run(async (context) =>
//       {
//         await context.Response.WriteAsync("Hello World!");
//       });
//     }
//   }

// }