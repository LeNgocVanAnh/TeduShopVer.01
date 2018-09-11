﻿using TeduShop.Data.Infrastructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IErrorRepository : IRepository<Error>
    {
    }

    public class ErrorRepository : RepositoryBase<Error>
    {
        public ErrorRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}