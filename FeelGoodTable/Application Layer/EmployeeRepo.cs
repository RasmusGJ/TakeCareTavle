using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using FeelGoodTable.Domain_Layer;

namespace FeelGoodTable
{
    public class EmployeeRepo
    {
        public List<Employee> employees = new List<Employee>();
        private List<CheckIn> checkIns = new List<CheckIn>();
        string todayDate = DateTime.Now.ToString("yyyy-dd-MM");
        public EmployeeRepo()
        {
            string ConnectionString = "Server=10.56.8.32;Database=A_GRUPEDB02_2019;User Id=A_GRUPE02;Password=A_OPENDB02";
            //GET ALL EMPLOYEES
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string pinCodeQuery = "SELECT Employee.Id, Employee.Initials FROM Employee INNER JOIN Role ON Employee.Role_Id = Role.Id INNER JOIN Department ON Role.Department_Id = Department.Id ORDER BY Department.SortId;";

                SqlCommand command = new SqlCommand(pinCodeQuery, conn);
                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employee employee = new Employee();
                        string resizedName = ResizeName(reader.GetString("Initials"));
                        employee.Id = reader.GetInt32("Id");
                        employee.Name = resizedName;
                        employees.Add(employee);
                    }
                }
            }
            //GET ALL CHECKINS FOR EMPLOYEES
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string pinCodeQuery = "SELECT Employee_Id, Mood.Img FROM CheckIn INNER JOIN Mood ON CheckIn.Mood_Id = Mood.Id WHERE FromDateTime >= '" + todayDate + "' AND ToDatetime = '1900-01-01' AND Guest_Id IS null ORDER BY Employee_Id, FromDateTime;";

                SqlCommand command = new SqlCommand(pinCodeQuery, conn);
                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CheckIn checkIn = new CheckIn();
                        checkIn.Employee_Id = reader.GetInt32("Employee_Id");
                        checkIn.Img = reader.GetString("Img");
                        checkIns.Add(checkIn);
                    }
                }
            }
            CombineLists();
        }       
        private string ResizeName(string n)
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
        private void CombineLists()
        {
            foreach (Employee employee in employees)
            {
                CheckIn temp = checkIns.Find(x => x.Employee_Id == employee.Id);
                try
                {
                    if (temp.Img != "")
                    {
                        employee.Mood = temp.Img;
                    }
                }
                catch (Exception)
                {
                    employee.Mood = "FÅK";
                }
            }
        }
    }
}
