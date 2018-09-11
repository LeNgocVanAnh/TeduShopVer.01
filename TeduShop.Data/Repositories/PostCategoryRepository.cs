using TeduShop.Data.Infrastructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IPostCategory : IRepository<PostCategory>
    {
    }

    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategory
    {
        public PostCategoryRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}