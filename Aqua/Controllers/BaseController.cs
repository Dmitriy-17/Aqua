using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Infrastructure.Contracts;
using Infrastructure.Contracts.Repo;
using Infrastructure.Entities.Contract;

namespace Aqua.Controllers
{
    public class BaseController : Controller
    {
        private ICreateRepository<IEntity> mCreateRepository;
        private IReadRepository<IEntity> mReadRepository;
        private IUpdateRepository<IEntity> mUpdateRepository;
        private IDeleteRepository<IEntity> mDeleteRepository;


        public BaseController(ICreateRepository<IEntity> createRepo,
            IReadRepository<IEntity> readRepo,
            IUpdateRepository<IEntity> updateRepo,
            IDeleteRepository<IEntity> deleteRepo)
        {
            mCreateRepository = createRepo;
            mReadRepository = readRepo;
            mUpdateRepository = updateRepo;
            mDeleteRepository = deleteRepo;
        }

       
    }
}