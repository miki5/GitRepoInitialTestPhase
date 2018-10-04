using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GitRepoInitialTest.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Managing()
		{
			ViewData["Message"] = "Git - local-branching-on-the-cheap";

			return View();
		}

        [HttpPost]
        public IActionResult ManagingPOST(string searchValue)
        {
            string test = HelperRepository.HelperSaveToGit.GitRepo();

            return View("Managing");
        }
    }
}