namespace CompanyHierarchy
{
    interface IEmployee
    {
        Departments Department { get; set; }
        decimal Salary { get; set; }
    }
}
