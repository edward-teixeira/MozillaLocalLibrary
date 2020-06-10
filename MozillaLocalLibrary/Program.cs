﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MozillaLocalLibrary.Data;
using MozillaLocalLibrary.Data.Seeds;

namespace MozillaLocalLibrary
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           CreateWebHostBuilder(args)
                                    .Build()
                                    .Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
