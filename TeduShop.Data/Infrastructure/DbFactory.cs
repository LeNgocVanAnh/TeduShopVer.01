namespace TeduShop.Data.Infrastructure
{
    // không kế thừa từ 2 object class được
    // 1 interface 1 object class thì được
    // khởi tạo các đối tượng dbContext thông qua factory
    public class DbFactory : Disposable, IDbFactory
    {
        //khai báo 1 biến
        private TeduShopDbContext dbContext;
        //phương thức init khởi tạo 1 đối tượng cho dbContext
        public TeduShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TeduShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}