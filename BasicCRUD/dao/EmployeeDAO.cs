using BasicCRUD.dto;
using BasicCRUD.utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCRUD.dao
{
    class EmployeeDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();

        public List<EmployeeDTO> getAll() {
            conn.Open();
            String query = "SELECT * FROM employee";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) {   //kiểm tra dữ liệu lấy về có rows nào không
                while (reader.Read()) {
                    //Lấy vị trí cột theo tên cộ`
                    int empIDIndex = reader.GetOrdinal("empID");
                    int empNameIndex = reader.GetOrdinal("empName");
                    int empCodeIndex = reader.GetOrdinal("empCode");

                    //Show ra console giá trị của cột đó theo vị trí đã lấy ở trên
                    Console.WriteLine("--------------------");
                    Console.WriteLine("empID: " + reader.GetInt32(empIDIndex));
                    Console.WriteLine("empCode: " + reader.GetString(empCodeIndex));
                    Console.WriteLine("empName: " + reader.GetString(empNameIndex));

                }
            }
            conn.Close();
            return null;
        }

        public EmployeeDTO getByID(int empID) {
            conn.Open();
            String query = "SELECT * FROM employee where empID = @empID";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            // Gán giá trị cho tham số @empID
            cmd.Parameters.Add("@empID",MySqlDbType.Int32).Value = empID;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) {   //kiểm tra dữ liệu lấy về có rows nào không
                while (reader.Read())
                {   
                    // Lấy giá trị ra nhưng viết ngắn hơn
                    int employeeID = reader.GetInt32(reader.GetOrdinal("empID"));
                    String empCode = reader.GetString(reader.GetOrdinal("empCode"));
                    String empName = reader.GetString(reader.GetOrdinal("empName"));

                    //Show ra console 
                    Console.WriteLine("--------------------");
                    Console.WriteLine("empID: " + employeeID);
                    Console.WriteLine("empCode: " + empCode);
                    Console.WriteLine("empName: " + empName);
                }             
            }
            conn.Close();
            return null;
        }

        public void create(EmployeeDTO employee) {
            conn.Open();
            try
            {
                String query = "INSERT INTO employee (empCode, empName) VALUES (@empCode, @empName)";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                // Cũng là gán tham số nhưng ngắn hơn
                cmd.Parameters.AddWithValue("@empCode", employee.empCode);
                cmd.Parameters.AddWithValue("@empName", employee.empName);
                // Thực thi Command (Dùng cho delete, insert, update).
                int rowCount = cmd.ExecuteNonQuery();

                Console.WriteLine("Row Count affected = " + rowCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            conn.Close();
        }

        public void update(int empID, EmployeeDTO employee) {
            conn.Open();
            try
            {
                String query = "UPDATE employee SET empCode = @empCode, empName = @empName WHERE empID = @empID";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                // Cũng là gán tham số nhưng ngắn hơn
                cmd.Parameters.AddWithValue("@empID", empID);
                cmd.Parameters.AddWithValue("@empCode", employee.empCode);
                cmd.Parameters.AddWithValue("@empName", employee.empName);
                // Thực thi Command (Dùng cho delete, insert, update).
                int rowCount = cmd.ExecuteNonQuery();

                Console.WriteLine("Row Count affected = " + rowCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            conn.Close();
        }

        public void delete(int empID) {
            conn.Open();
            try
            {
                String query = "DELETE FROM employee WHERE empID = @empID";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                // Cũng là gán tham số nhưng ngắn hơn
                cmd.Parameters.AddWithValue("@empID", empID);
                // Thực thi Command (Dùng cho delete, insert, update).
                int rowCount = cmd.ExecuteNonQuery();

                Console.WriteLine("Row Count affected = " + rowCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            conn.Close();
        } 
    }
}
