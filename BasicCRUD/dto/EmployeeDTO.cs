using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCRUD.dto
{
    class EmployeeDTO
    {
        public int empID { set; get; }

        public String empCode { set; get; }

        public String empName { set; get; }

        public EmployeeDTO() { }

        public EmployeeDTO(int empID, string empCode, string empName)
        {
            this.empID = empID;
            this.empCode = empCode;
            this.empName = empName;
        }

        public EmployeeDTO(string empCode, string empName)
        {
            this.empCode = empCode;
            this.empName = empName;
        }
    }
}
