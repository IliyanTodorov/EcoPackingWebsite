namespace EcoPacking.Web.Areas.Administration.Controllers
{
    using EcoPacking.Common;
    using EcoPacking.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public abstract class AdministrationController : BaseController
    {
    }
}
