
using System;
using Infrastructure.Contracts.Repo;
using System.Data.Entity;

namespace AdoNet.Repo
{
    public class BaseRepository : IBaseRepository
    {
        protected DbContext mContext;
        public BaseRepository(DbContext context)
        {
            mContext = context;
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    mContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
