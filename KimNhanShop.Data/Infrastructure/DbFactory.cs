using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimNhanShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private KimNhanShopDbContext dbContext;

        // Khi init sẽ kiểm tra?? Chưa có sẽ tự khởi tạo, có rồi thì thôi
        public KimNhanShopDbContext Init()
        {
            return dbContext ?? (dbContext = new KimNhanShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
