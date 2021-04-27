using BasicCRUD.dao;
using BasicCRUD.dto;
using BasicCRUD.utils;
using MySql.Data.MySqlClient;
using System;

namespace BasicCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDAO dao = new EmployeeDAO();
            Console.WriteLine("Hello World!");
            try
            {
                MySqlConnection connection = DBUtils.GetDBConnection();
                Console.WriteLine("Connection Success!");
                // Tao 1 thằng emp với các giá trị muốn update/create
                EmployeeDTO employee = new EmployeeDTO("code2", "name6");

                // Gọi cái method đã tạo ở DAO ra để test (Muốn test thằng nào thì comment mấy thằng khác lại):
                //Get All:
                dao.getAll();
                //Get By ID:
                dao.getByID(2);
                //Create::
                dao.create(employee);
                //Update:
                dao.update(2, employee);
                //Delete:
                dao.delete(2);
                // Note: 2 là số ID
            }
            catch (Exception)
            {
                Console.WriteLine("Connection failed!");
                throw;
            }
        }
    }
}
