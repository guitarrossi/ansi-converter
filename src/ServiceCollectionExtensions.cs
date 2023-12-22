using ANSIConverter.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANSIConverter
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureServices(ServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<MainForm>();
            serviceCollection.AddScoped<IEncodingService, EncodingService>();
        }
    }
}
