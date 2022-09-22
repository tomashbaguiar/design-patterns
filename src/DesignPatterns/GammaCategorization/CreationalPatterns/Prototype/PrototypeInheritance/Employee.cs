namespace DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.PrototypeInheritance;

public class Employee : Person, IDeepCopyable<Employee>
{
    public int Salary;
    
    public Employee(string[] names, Address address, int salary) : base(names, address)
    {
        Salary = salary;
    }

    public Employee()
    {
        
    }

    public void CopyTo(Employee target)
    {
        base.CopyTo(target);
        target.Salary = Salary;
    }
}