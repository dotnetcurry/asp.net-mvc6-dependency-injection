using System.Collections.Generic;

namespace ASPNET5_DIApp.Models
{
    public class EmployeeInfo
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
    }

    public class EmployeeDatabase : List<EmployeeInfo>
    {
        public EmployeeDatabase()
        {
            Add(new EmployeeInfo() { EmpNo = 1, EmpName = "A" });
            Add(new EmployeeInfo() { EmpNo = 2, EmpName = "B" });
            Add(new EmployeeInfo() { EmpNo = 3, EmpName = "C" });
            Add(new EmployeeInfo() { EmpNo = 4, EmpName = "D" });
            Add(new EmployeeInfo() { EmpNo = 5, EmpName = "E" });
        }
    }

    public class DataAccess
    {
        public List<EmployeeInfo> Get()
        {
            return new EmployeeDatabase();
        }
    }
}
