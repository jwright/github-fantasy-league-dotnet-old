using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GitHubFantasyLeague.Controllers
{
    public class UsersController : ApplicationController
    {
        public ActionResult Show(string id)
        {
            return Json(
                GithubFantasyLeague.Model.User.Find(id).Calculate(), 
                JsonRequestBehavior.AllowGet);
        }

    }
}
