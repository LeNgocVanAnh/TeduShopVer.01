using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    // dùng để thêm các phương thức mới thêm vào sau này
    // không cần viết lại các phương thức thêm xóa sửa
    public interface IProductCategoryRepositpry
    {
        // 1 phương thức ko nằm trong danh sách các phương thức có sẵn trong repository base
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepositpry
    {
        // nhận tham số truyền vào là 1 dbfactory
        // tự khởi tạo
        public ProductCategoryRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}