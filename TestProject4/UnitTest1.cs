using EmployeePayRollSystem;

namespace TestProject4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10EmployeeWhenAddedToListShouldMatchEmpEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();

            employeeDetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "Rita", phoneNumber: 9422136340, address: "11 streets", city: "Pune", state: "Maharashtra", department: "Finance", gender: "F"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 2, employeeName: "Sam", phoneNumber: 1243562563, address: "12 streets", city: "Bombay", state: "Maharashtra", department: "Finance", gender: "M"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 3, employeeName: "Joe", phoneNumber: 1234567890, address: "13 streets", city: "Gondia", state: "Maharashtra ", department: "HR", gender: "M"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 4, employeeName: "Roe", phoneNumber: 2415261627, address: "14 streets", city: "Bhopal", state: "Madhya Pradesh", department: "hr", gender: "M"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 5, employeeName: "Vilas", phoneNumber: 9936535290, address: "streets", city: "Mumbai", state: "Maharashtra", department: "HR", gender: "M"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 6, employeeName: "Steyn", phoneNumber: 8834567890, address: "15 streets", city: "Ranchi", state: "Maharashtra", department: "Marketing", gender: "M"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 7, employeeName: "Daniel", phoneNumber: 9898567890, address: "16 streets", city: "Bhandara", state: "Maharashtra", department: "HR", gender: "F"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 8, employeeName: "Roy", phoneNumber: 7565123456, address: " 27 streets ", city: "Lakhni", state: "Maharashtra", department: "Finance", gender: "M"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 9, employeeName: "Jposh", phoneNumber: 9738567890, address: " 28 streets ", city: "Nagpur", state: "Maharashtra", department: "Finance", gender: "M"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 10, employeeName: "Amit", phoneNumber: 9090567890, address: "  18 streets ", city: "Pune", state: "Maharashtra", department: "Manager", gender: "M"));


            EmployeePayRollOperation employeePayRollOperation = new EmployeePayRollOperation();
            DateTime startTime = DateTime.Now;
            employeePayRollOperation.AddEmployeeToPayRoll(employeeDetails);
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Duration without thread " + (endTime - startTime));

            DateTime threadtartTime = DateTime.Now;
            employeePayRollOperation.AddEmployeeToPayRollWithThread(employeeDetails);
            DateTime threadendTime = DateTime.Now;
            Console.WriteLine("Duration with thread: " + (threadendTime - threadtartTime));
        }
    }
    
}