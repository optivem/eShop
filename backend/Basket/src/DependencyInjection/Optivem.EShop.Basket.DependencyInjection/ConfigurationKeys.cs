using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace Optivem.EShop.Basket.DependencyInjection
{
    public static class ConfigurationKeys
    {
        public const string DatabaseConnectionKey = "DefaultConnection";

        public static Action<SqlServerDbContextOptionsBuilder> SqlServerOptionsAction = b => b.MigrationsAssembly("Optivem.EShop.Basket.Infrastructure.EntityFrameworkCore.Migrations");
    }
}