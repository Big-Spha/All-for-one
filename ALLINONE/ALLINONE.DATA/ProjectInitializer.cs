using System;
using System.Data.Entity;

namespace ALLINONE.DATA
{
    public class ProjectInitializer : DropCreateDatabaseIfModelChanges<ProjectContex>
    {
        protected override void Seed(ProjectContex context)
        {
            context.Students.Add(new Student
            {
                StudentId = 21314043,
                Name = "Spha",
                Lastname = "Sishi",
                Email = "sphasishi412@gmail.com",
                Address = "Alpine Dut Res",
                Course = "Information Technology Business Applications"


            });

            context.Items.Add(new Item
            {
                ItemId = 21,
                Instock = false,
                Price = 70,
                Size = "Medeum",
                Desc = "CustomizedGolf T-Shirt "

            });

            context.OrderItems.Add(new OrderItem
            {
                OrderItemId = 2131,              
                OrderId = 2131404301,
                Qty = 2

            });

            context.Orders.Add(new Order
            {
                OrderId = 2131404301,
                Closed = true,
                OrderDate = new DateTime(04 - 05 - 2016),
                OderItemId = 21,
                StudentId = 21314043

            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
