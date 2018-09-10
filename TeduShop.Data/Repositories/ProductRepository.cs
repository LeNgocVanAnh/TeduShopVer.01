using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    // không cần viết phương thức do đã làm chung
    public interface IProductRepository
    {

    }
    public class ProductRepository: RepositoryBase<Product>, IProductRepository
    {
        //kế thừa constructure
        //lúc khởi tạo repository của product truyền vào dbfactory đồng thời cũng lấy giá trị đấy truyền vào 
        //constructure của base để khởi tạo ra repository base
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
