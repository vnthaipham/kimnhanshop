using KimNhanShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimNhanShop.Data
{
    // Nếu chúng ta truy cập Db sẽ cần tạo 1 context và truy cập vào thông qua các thuộc tính được tạo phía dưới
    public class KimNhanShopDbContext: DbContext
    {
        public KimNhanShopDbContext() : base("KimNhanShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false; //Load bảng cha không load thêm bảng con
        }

        public DbSet<Footer> Footers { get; set; } //Tên thuộc tính số nhiều
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }

        //ghi Đè phương thức của DbContext. Chạy khi khởi tạo Entity Framework
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
