using System;

namespace KimNhanShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        KimNhanShopDbContext Init(); // Tạo ra Phương thức để init DbContext
    }
}