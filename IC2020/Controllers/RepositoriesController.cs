using IC2020.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace IC2020.Controllers
{
    public class RepositoriesController : Controller
    {
        private AuxOperations _operations = new AuxOperations();


        public ActionResult Home()
        {
            return View();
        }

        [DisableRequestSizeLimit]
        public IActionResult MyRepositories()
        {
            var url = "https://api.github.com/users/RogerioTostes/repos";
            var result = _operations.GetStrFromJson(url);
            var myRepos = JsonConvert.DeserializeObject<List<Item>>(result);

            return View(myRepos);
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult SearchResult(string key)
        {
            var url = "https://api.github.com/search/repositories?q=" + key.ToLower();
            var searchResult = _operations.GetStrFromJson(url);
            var repos = JsonConvert.DeserializeObject<Repos>(searchResult);

            return View(repos);
        }


        //public IActionResult Favorites(Item fav)
        //{
        //    if (fav.id != 0)
        //    {
        //        _operations.DBInsert(fav);
        //    }
        //    return View();
        //}

        //public IActionResult RemoveFromFavs(Item fav)
        //{
        //    if (fav.id != 0) _operations.DBDelete(fav);
        //    return RedirectToAction("Favorites", null);
        //}

        [DisableRequestSizeLimit]
        public IActionResult RepInfo(Item i)
        {
            var collabsUrl = i.contributors_url;
            var collabs = JsonConvert.DeserializeObject<List<Collabs>>(_operations.GetStrFromJson(collabsUrl));
            // Object structure used to return general info and collaborators of a repository
            var objs = new ObjStructure();
            objs.generalInfo = i;
            objs.collaborators = collabs;

            return View(objs);
        }
    }
}