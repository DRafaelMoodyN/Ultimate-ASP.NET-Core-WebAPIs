namespace Services {
    public sealed class EmployeeService : IEmployeeService {
        private readonly IRepositoryManager _repositoryManager;

        public EmployeeService(IRepositoryManager repositoryManager) {
            _repositoryManager = repositoryManager;
        }
    }
}
