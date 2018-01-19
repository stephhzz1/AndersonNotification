using System;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System.Web.Http;
using System.Web.Mvc;

namespace AndersonNotificationWeb
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureCookie(app);
            HttpConfiguration config = new HttpConfiguration();
            AreaRegistration.RegisterAllAreas();
            app.UseWebApi(config);
        }
        public void ConfigureCookie(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Credential/Login")
            });


        }
    }
}