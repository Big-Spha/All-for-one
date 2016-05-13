using System.Data.Entity;

namespace ALLINONE.DATA
{
   public  class ProjectContex: DbContext
    {

        public ProjectContex()
            :base("Name=allinoneproject")
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PoItem> PoItems { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
}
