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
        public ActionResult DashBoard(string usuario, string repositorio)
        {
            var url = "https://api.github.com/repos/" + usuario + "/" + repositorio + "/releases";
            var result = _operations.GetStrFromJson(url);
            var myRepos = JsonConvert.DeserializeObject<List<Item>>(result);
            var url1 = "https://api.github.com/repos/" + usuario + "/" + repositorio;
            var result1 = _operations.GetStrFromJson(url1);
            var myRepos1 = JsonConvert.DeserializeObject<RepoInfo>(result1);
            var objs = new ObjStructure();
            objs.item = myRepos;
            objs.repo = myRepos1;
            return View(objs);
        }        

        public ActionResult Search()
        {
            return View();
        }     
              

    }
}