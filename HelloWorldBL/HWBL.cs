using HelloWorldDAL;
using HelloWorldDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldBL
{
    public class HWBL
    {
      public List<DepartmentDTO> GetAllDepartments()
        {
            try
            {
                HWDAL dalObj = new HWDAL();
                List<DepartmentDTO> results = dalObj.FetchAllDepartments();
                return results;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
