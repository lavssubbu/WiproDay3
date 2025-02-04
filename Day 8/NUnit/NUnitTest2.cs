using SampleTestDemo;

namespace TestProjectnunit;

public class NUnitTest2
{
    private EmployeeManager employeeManager;   
    public void Setup()
    {
        employeeManager = new EmployeeManager();
    }

    [Test]
    public void AddEmployee_ShouldAddEmployee()
    {
        var employee = new EmployeeCla("John Doe", "E001", "IT", 60000);
        employeeManager.AddEmployee(employee);

        var employees = employeeManager.ViewEmployees();
        Assert.AreEqual(1, employees.Count);
        Assert.AreEqual("John Doe", employees[0].Name);
    }

    [Test]
    public void UpdateEmployee_ShouldUpdateEmployeeDetails()
    {
        var employee = new EmployeeCla("Jane Doe", "E002", "HR", 50000);
        employeeManager.AddEmployee(employee);

        bool result = employeeManager.UpdateEmployee("E002", "Finance", 55000);

        Assert.IsTrue(result);
        var updatedEmployee = employeeManager.SearchEmployee("E002");
        Assert.AreEqual("Finance", updatedEmployee.Department);
        Assert.AreEqual(55000, updatedEmployee.Salary);
    }

    [Test]
    public void UpdateEmployee_ShouldReturnFalseIfNotFound()
    {
        bool result = employeeManager.UpdateEmployee("E999", "Marketing", 45000);
        Assert.IsFalse(result);
    }

    [Test]
    public void RemoveEmployee_ShouldRemoveEmployee()
    {
        var employee = new EmployeeCla("Mark Smith", "E003", "Operations", 65000);
        employeeManager.AddEmployee(employee);

        bool result = employeeManager.RemoveEmployee("E003");

        Assert.IsTrue(result);
        Assert.IsNull(employeeManager.SearchEmployee("E003"));
    }

    [Test]
    public void RemoveEmployee_ShouldReturnFalseIfNotFound()
    {
        bool result = employeeManager.RemoveEmployee("E999");
        Assert.IsFalse(result);
    }

    [Test]
    public void SearchEmployee_ShouldReturnCorrectEmployee()
    {
        var employee = new EmployeeCla("Alice Brown", "E004", "Sales", 70000);
        employeeManager.AddEmployee(employee);

        var foundEmployee = employeeManager.SearchEmployee("E004");

        Assert.IsNotNull(foundEmployee);
        Assert.AreEqual("Alice Brown", foundEmployee.Name);
    }

    [Test]
    public void SearchEmployee_ShouldReturnNullIfNotFound()
    {
        var foundEmployee = employeeManager.SearchEmployee("E999");
        Assert.IsNull(foundEmployee);
    }
}
