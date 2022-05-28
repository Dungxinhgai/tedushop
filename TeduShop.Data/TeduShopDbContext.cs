using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Models;

namespace TeduShop.Data
{
    public class TeduShopDbContext:DbContext
    {
        public TeduShopDbContext() : base("TeduShopconnection")
        {
            this.Configuration.LazyLoadingEnabled = false;//khi load bang cha ko tu dong include bang con
        }
        // khai bao cac bang
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystermConfig> SystermConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisistorStatic> VisistorStatics { get; set; }
        // ghi de mot phuong thuc cua DBcontext
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            
        }

    }
}
