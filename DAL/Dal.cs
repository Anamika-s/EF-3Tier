using BusinessObject.Models;
using DAL.Context;

namespace DAL
{
    public class Dal
    {
        InventoryDbContext db = new InventoryDbContext();

        public int AddSupplier(Supplier supplier)
        {
            db.Suppliers.Add(supplier);
            db.SaveChanges();
            return 0;
        }

        public int UpdateSupplier(int id, Supplier supplier)
        {

            return 0;

        }
        public int DeleteSupplier(int id)
        {
            return 0;
        }

        public List<Supplier> GetSuppliers()
        {
            return db.Suppliers.ToList();
        }
    }
}