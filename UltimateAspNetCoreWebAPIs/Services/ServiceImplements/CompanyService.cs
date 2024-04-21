namespace Services {
    public sealed class CompanyService : ICompanyService {
        private readonly IRepositoryManager _repositoryManager;

        public CompanyService(IRepositoryManager repositoryManager) {
            _repositoryManager = repositoryManager;
        }
    }
}
