namespace Repository {
    public class RepositoryManager : IRepositoryManager {

        private readonly AppDbContext _dbContext;

        // Lazy cargar diferida, se utiliza para retrasar la creacion de objectos o la ejecucion
        // de una accion hasta el momento en que realmente se nesesiten
        private Lazy<ICompanyRepository> _companyRepository;
        private Lazy<IEmployeeRepository> _employeeRepository;

        public RepositoryManager(AppDbContext dbContext) {
            _dbContext = dbContext;
            _companyRepository = new Lazy<ICompanyRepository>(()
                => new CompanyRepository(dbContext));

            _employeeRepository = new Lazy<IEmployeeRepository>(() =>
            new EmployeeRepository(dbContext));
        }
        public ICompanyRepository CompanyRepository => _companyRepository.Value;
        public IEmployeeRepository EmployeeRepository => _employeeRepository.Value;

        public void Save() {
            _dbContext.SaveChanges();
        }
    }
}
