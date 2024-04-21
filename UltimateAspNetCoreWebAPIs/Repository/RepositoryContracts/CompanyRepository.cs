namespace Repository {
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository {
        public CompanyRepository(AppDbContext dbContext)
            : base(dbContext) {

        }
    }
}
