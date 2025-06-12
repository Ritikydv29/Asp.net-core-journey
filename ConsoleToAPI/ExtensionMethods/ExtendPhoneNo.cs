using ConsoleToAPI.Models;

namespace ConsoleToAPI.ExtensionMethods
{
    public static class ExtendPhoneNo
    {
        public static string AddPhone(this EmployeesModel emp) {
            if (!emp.Phone_No.StartsWith("+91"))
            {
                emp.Phone_No = "+91" + emp.Phone_No;
                return emp.Phone_No;
            }
            return emp.Phone_No;
        }
    }

}
