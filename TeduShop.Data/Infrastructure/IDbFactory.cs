using System;

namespace TeduShop.Data.Infrastructure
{
    // khoi tao entityfamewrok
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}