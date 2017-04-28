using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Infrastructure.Aquarium;
using Infrastructure.Contracts.Repo;
using Infrastructure.Entities.Contract;

namespace Aqua.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(
            ICreateRepository<Contract> createRepo,
            IReadRepository<Contract> readRepo,
            IUpdateRepository<Contract> updateRepo,
            IDeleteRepository<Contract> deleteRepo) : base(createRepo, readRepo, updateRepo, deleteRepo)
        {
          

        }
        public async Task<ActionResult> Index()
        {
            var contract = new Contract()
            {
                Name = "sgh1111112222222221"
            };
            //mCreateRepository.Create(contract);

             var k = await mReadRepository.GetById(3);
            k.Name = "modif";
            mUpdateRepository.Updade(k);
            mDeleteRepository.Delete(5);
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
