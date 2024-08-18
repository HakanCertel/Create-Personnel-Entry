using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using PersonelApp.Model.Concrete.Entities;
using PersonnelApp.Bll.Abstract;
using PersonnelApp.Model.Concrete.Entities;
using PersonnelApp.WebUI.Models;
using PersonnelManagement.Bll.Abstract;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace PersonnelApp.WebUI.Controllers
{
    public class MaterialController : Controller
    {
        private readonly IMaterialService _materialService;
        public MaterialController(IMaterialService materialService)
        {
            _materialService = materialService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new MaterialModel());
        }
        [HttpPost]
        public IActionResult Create(MaterialModel p)
        {
            var entity = new Materials
            {
                Id = p.Id,
                Code = p.Code,
                Name = p.Name,
                Unit = p.Unit,
            };
            _materialService.Create(entity);
            return Redirect("/Material/List");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            return View(_materialService.GetEntity(x => x.Id == id));
        }
        [HttpPost]
        public IActionResult Edit(Materials p)
        {
            _materialService.Update(p);
            return RedirectToAction("list");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var material = _materialService.GetEntity(x => x.Id == id);

            _materialService.Delete(material);
            return RedirectToAction("list");
        }
        public IActionResult List()
        {
            return View(_materialService.List(null));
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
