using System.Data.Entity;

namespace Proyecto11.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Proyecto11.Models.Employ> Employs { get; set; }
    }
}