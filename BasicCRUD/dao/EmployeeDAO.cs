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
            
            conn.Close();
            return null;
        }

        public EmployeeDTO getByID(int empID) {
            conn.Open();
           
            conn.Close();
            return null;
        }

        public void create(EmployeeDTO employee) {
            conn.Open();
            
            conn.Close();
        }

        public void update(int empID, EmployeeDTO employee) {
            conn.Open();
            
            conn.Close();
        }

        public void delete(int empID) {
            conn.Open();
            
            conn.Close();
        } 
    }
}
