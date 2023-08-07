using QLBHST.DALL;
using QLBHST.MODELL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHST.BALL
{
    public class CustomerBAL
    {
        CustomerDAL dal = new CustomerDAL();
        public List<CustomerBEL> ReadCustomer()
        {
            List<CustomerBEL> lstCus = dal.ReadCustomer();
            return lstCus;
        }
        public void NewCustomer(CustomerBEL cus)
        {
            dal.NewCustomer(cus);
        }
        public void DeleteCustomer(CustomerBEL cus)
        {
            dal.DeleteCustomer(cus);
        }
        public void EditCustomer(CustomerBEL cus)
        {
            dal.EditCustomer(cus);
        }


    }
}
