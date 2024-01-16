namespace EmployeeManagementSys.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public Position Position { get; set; }
        public double Salary { get; set; }

    }

    public enum Position
    {
        CTO,
        CIO,
        CEO,
        ProjectManager,
        ProductManager,
        Manager,
        Developer,
        Tester,
        Designer,
        DatabaseAdministrator,
        SystemAdministrator,
        DevOpsEngineer,
        SecurityEngineer,
        TechnicalWriter,
        HelpdeskSpecialist,
        AgileCoach,
        Analyst,
        SalesandMarketingProfessionals,
        HR,
        FinanceandAccountingProfessionals
    }
}
