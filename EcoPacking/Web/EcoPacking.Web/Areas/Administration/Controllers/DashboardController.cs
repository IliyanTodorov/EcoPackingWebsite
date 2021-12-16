namespace EcoPacking.Web.Areas.Administration.Controllers
{
    using System.Linq;

    using EcoPacking.Data.Common.Repositories;
    using EcoPacking.Data.Models;
    using EcoPacking.Web.Areas.Administration.ViewModels;
    using Microsoft.AspNetCore.Mvc;

    public class DashboardController : AdministrationController
    {
        private readonly IDeletableEntityRepository<ApplicationUser> usersRepository;

        public DashboardController(IDeletableEntityRepository<ApplicationUser> usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public IActionResult Index()
        {
            return this.View(new IndexViewModel());
        }
    }
}
