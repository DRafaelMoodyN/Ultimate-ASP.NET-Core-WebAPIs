
namespace Repository {
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class {

        protected AppDbContext AppDbContext;

        public RepositoryBase(AppDbContext appDbContext) => AppDbContext = appDbContext;
        public void Create(T entity) {
            AppDbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity) {
            AppDbContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll(bool trackChanges) {
            return !trackChanges ? AppDbContext.Set<T>().AsNoTracking() : AppDbContext.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) {
            return !trackChanges ? AppDbContext.Set<T>()
                .Where(expression).AsNoTracking()
                : AppDbContext.Set<T>().Where(expression);
        }

        public void Update(T entity) {
            AppDbContext.Set<T>().Update(entity);
        }
    }
}
