namespace Sales.Domain.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        //Cada que instancia una clase data o un objeto data context se conecta a default connection
        public DataContext() : base("ListInsc_Connection")
        {

        }

        public System.Data.Entity.DbSet<Sales.Common.Models.Product> Products { get; set; }
    }
}
