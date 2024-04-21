
namespace Services {
    public class ServiceManager : IServiceManager {

        private readonly Lazy<IEmployeeService> _employeeService;
        private readonly Lazy<ICompanyService> _companyService;

        public ServiceManager(IRepositoryManager repositoryManager) {
            _employeeService = new Lazy<IEmployeeService>(() =>
            new EmployeeService(repositoryManager));

            _companyService = new Lazy<ICompanyService>(() =>
            new CompanyService(repositoryManager));
        }
        public ICompanyService CompanyService => _companyService.Value;
        public IEmployeeService EmployeeService => _employeeService.Value;
    }
}
