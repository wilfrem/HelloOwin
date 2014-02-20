using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin;

namespace HelloOwin
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(async context => await context.Response.WriteAsync("Hello, World"));
        }
    }
}
