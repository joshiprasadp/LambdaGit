using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CY.TestGet
{
    public class StartUp
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }
    }
}
