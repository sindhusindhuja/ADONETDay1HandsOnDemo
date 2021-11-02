using HelloWorldBL;
using HelloWorldDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Connection String : 
            //Server Name
            //Authentication Mode
            //Name of the Database
        
            try
            {
                HWBL blObj = new HWBL();
                List<DepartmentDTO> lstFinalResult=blObj.GetAllDepartments();
                foreach (var dept in lstFinalResult)
                {
                    Console.WriteLine(dept.DeptName+"|"+dept.DeptGroupName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Our developers are working on it.Please quote the error message before when you contact customer care");
                Console.WriteLine(ex.Message);
            }



        }
    }
}
