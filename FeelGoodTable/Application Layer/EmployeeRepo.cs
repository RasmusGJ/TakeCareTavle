using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FeelGoodTable
{
    public class EmployeeRepo
    {
        public List<Employee> employees = new List<Employee>();
        public EmployeeRepo()
        {
            Employee employee = new Employee();
            employee.Name = "Mette";
            employee.Mood = "HappySmiley.png";
            Employee employee2 = new Employee();
            employee2.Name = "Kia";
            employee2.Mood = "SadSmiley.png";

            AddEmployee(employee);
            AddEmployee(employee2);
            /*
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=10.56.8.32;Database=A_GRUPEDB02_2019;User Id=A_GRUPE02;Password=A_OPENDB02";

                string pinCodeQuery = "SELECT Employee.Name FROM Employee INNER JOIN Role ON Employee.Role_Id = Role.Id INNER JOIN Department ON Role.Department_Id = Department.Id ORDER BY Department.Id";

                SqlCommand command = new SqlCommand(pinCodeQuery);
                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employee employee = new Employee();
                        string resizedName = ResizeName(reader.GetString("Name"));
                        employee.Name = resizedName;
                        AddEmployee(employee);
                    }
                }
            }
            */
        }       

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public string ResizeName(string n)
        {
            string result = "";
            string s = " ";

            char[] name = n.ToCharArray();
            char[] space = s.ToCharArray();

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == space[0])
                {
                    return result;
                }
                result += name[i];
            }
            return result;
        }
    }
}
