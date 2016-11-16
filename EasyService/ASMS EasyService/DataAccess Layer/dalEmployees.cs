using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS_EasyService.Employees;

namespace ASMS_EasyService.DataAccess_Layer
{
    class dalEmployees
    {
        private static List<Employee> ListOfEmployees = new List<Employee>();

        public static void Insert(Employee employee)
        {
            ListOfEmployees.Add(employee);
        }

        public static void Delete(Employee employee)
        {
            ListOfEmployees.Remove(employee);
        }

        public static List<Employee> GetAll()
        {
            return ListOfEmployees;
        }
    }
}
