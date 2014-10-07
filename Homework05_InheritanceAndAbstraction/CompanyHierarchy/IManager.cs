namespace CompanyHierarchy
{
    using System.Collections.Generic;

    interface IManager
    {
        IList<Employee> Employees { get; set; }
    }
}
