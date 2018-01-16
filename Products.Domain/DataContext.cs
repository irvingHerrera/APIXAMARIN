using System.Data.Entity;

namespace Products.Domain
{
    public class DataContext : DbContext
    {
        protected DataContext() : base("DefaultConnection")
        {
        }
    }
}
