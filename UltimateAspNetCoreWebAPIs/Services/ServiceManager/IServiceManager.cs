
namespace Services {
    public interface IServiceManager {
        public ICompanyService CompanyService { get; }
        public IEmployeeService EmployeeService { get; }
    }
}
