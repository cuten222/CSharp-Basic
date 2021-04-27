using BasicCRUD.dto;
using BasicCRUD.utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCRUD.dao
{
    class EmployeeDAOProcedure
    {
        MySqlConnection conn = DBUtils.GetDBConnection();

        public List<EmployeeDTO> getAll()
        {
            conn.Open();

            conn.Clone();
            return null;
        }

        public EmployeeDTO getByID(int empID)
        {
            conn.Open();

            conn.Clone();
            return null;
        }

        public void create(EmployeeDTO employee)
        {
            conn.Open();

            conn.Clone();
        }

        public void update(int empID, EmployeeDTO employee)
        {
            conn.Open();

            conn.Clone();
        }

        public void delete(int empID)
        {
            conn.Open();

            conn.Clone();
        }
    }
}
