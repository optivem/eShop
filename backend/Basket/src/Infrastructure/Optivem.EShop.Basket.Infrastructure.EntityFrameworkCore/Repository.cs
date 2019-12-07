using Optivem.Framework.Infrastructure.EntityFrameworkCore;

namespace Optivem.EShop.Basket.Infrastructure.EntityFrameworkCore
{
    public class Repository : Repository<DatabaseContext>
    {
        public Repository(DatabaseContext context) : base(context)
        {
        }
    }
}
