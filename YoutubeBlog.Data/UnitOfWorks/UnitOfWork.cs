using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Repositories.Abstracts;
using YoutubeBlog.Data.Repositories.Concretes;

namespace YoutubeBlog.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await dbContext.DisposeAsync(); 
        }

        public int Save()
        {
            return dbContext.SaveChanges();
        }

        IRepository<T> IUnitOfWork.GetRepository<T>()
        {
            return new Repository<T>(dbContext);
        }
    }
}
