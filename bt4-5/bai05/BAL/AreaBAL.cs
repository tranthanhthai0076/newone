using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai05.DAL;
using bai05.Model;

namespace bai05.BAL
{
    public class AreaBAL
    {
        AreaDAL dal = new AreaDAL();
        public List<AreaBEL> ReadAreaList()
        {
            List<AreaBEL> lstArea = dal.ReadAreaList();
            return lstArea;
        }
    }
}
