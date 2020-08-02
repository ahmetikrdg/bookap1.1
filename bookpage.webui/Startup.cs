using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace bookpage.webui
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {//serisleri proje içine dahil ederiz
            services.AddControllersWithViews();//mvc yapısını kullandım controlleri kullanacağım dedim
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();//wwwroot altındaki klasörler açılır
            app.UseStaticFiles(new StaticFileOptions{
                FileProvider=new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                    RequestPath="/modules"
               
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
           

            app.UseEndpoints(endpoints =>//uygulamanın ana dizinine sahip istek geldiğinde bir response string ifade göndermek
            {
                endpoints.MapControllerRoute(
                 name: "default",
                 pattern: "{controller=Product}/{action=Index}/{id?}"
                //controller=home dedim yani sen birşey çağırmasan bile ilk olarak home çıkar karşına actionu ise ındex
                );
            });
        }
    }
}
