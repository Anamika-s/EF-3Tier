using BusinessObject.Models;
using DAL;

namespace BAL
{
    public class Bal
    {
        Dal dal = new Dal();
        public int AddSupplier(Supplier supplier)
        {
            dal.AddSupplier(supplier);
            return 1;
        }
        public int UpdateSupplier(int id, Supplier supplier)
        {
            dal.UpdateSupplier(id, supplier);
            return 1;
        }

    }
}