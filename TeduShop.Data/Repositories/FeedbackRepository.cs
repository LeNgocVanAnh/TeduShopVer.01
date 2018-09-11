using TeduShop.Data.Infrastructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IFeedbackRepository : IRepository<FeedBack>
    {
    }

    public class FeedbackRepository : RepositoryBase<FeedBack>, IFeedbackRepository
    {
        public FeedbackRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}