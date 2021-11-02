using HelloWorldDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDAL
{
    public class HWDAL
    {
        //Reference Variable : Class Level : Member Variables
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;
        SqlDataReader sqlDataReaderObj;
        public HWDAL()
        {
            sqlConObj = new SqlConnection();
            sqlCmdObj = new SqlCommand();
            
        }
        public List<DepartmentDTO> FetchAllDepartments()
        {
            try
            {
                //Setting up the connectionstring to the connection object
                sqlConObj.ConnectionString = ConfigurationManager.
                    ConnectionStrings["AdvWorksDBConnStr"].ConnectionString;
                //SEtting up the command text for the command object
                sqlCmdObj.CommandText = @"SELECT Name,GroupName FROM HumanResources.Department";
                sqlCmdObj.Connection = sqlConObj;

                //Execute
                sqlConObj.Open();//COnnection should be open not command
                sqlDataReaderObj=sqlCmdObj.ExecuteReader();
                List<DepartmentDTO> lstDept = new List<DepartmentDTO>();

                DepartmentDTO newepartObj = new DepartmentDTO();

                while(sqlDataReaderObj.Read())
                {
                    //newepartObj.DeptName = sqlDataReaderObj[0].ToString();
                    //newepartObj.DeptGroupName = sqlDataReaderObj[1].ToString();
                    //lstDept.Add(newepartObj);

                    lstDept.Add(new DepartmentDTO()
                    {
                        DeptName = sqlDataReaderObj[0].ToString(),
                        DeptGroupName = sqlDataReaderObj[1].ToString()
                    });

                }
                return lstDept;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally{

                sqlConObj.Close();
            }

        }
       


    }
}
