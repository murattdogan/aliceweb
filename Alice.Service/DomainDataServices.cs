using Alice.Data.Context;
using Alice.Data.Model;
using Alice.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service
{
    public static class DomainDataServices
    {
        public static IServiceCollection SetUpAppDependencies(this IServiceCollection serviceCollection)
        {
            //serviceCollection.AddDbContext<LuxuryContext>(option => { if (!option.IsConfigured) option.UseMySQL("server=142.93.172.93;port=3306;database=luxuryistanbul;uid=appuser;password=Xvsc3711!"); });
            return serviceCollection;
        }
    }
}
