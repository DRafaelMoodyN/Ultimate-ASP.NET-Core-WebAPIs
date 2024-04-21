
namespace Repository {
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository {
        public EmployeeRepository(AppDbContext dbContext)
            : base(dbContext) {
        }
    }
}
