using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDA
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext()
            : base()
        {

        }

        
        public virtual DbSet<Products> ProductName { get; set; }
        

        //public virtual ObjectResult<Products> GetPrice_ResultbyID(Nullable<int> ID)
        //{
        //    var productIdParameter = ID.HasValue ?
        //        new ObjectParameter("ID", ID) :
        //        new ObjectParameter("ProductName", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Products>("GetPrice_ResultbyID", productIdParameter);
        //}
    }
}
