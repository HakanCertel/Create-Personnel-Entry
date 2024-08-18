using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PersonelApp.Model.Concrete.Entities;
using PersonnelApp.WebUI.Models;
using PersonnelManagement.Bll.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PersonnelApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonnelService _personnelService;
        public HomeController(IPersonnelService personnelService)
        {
            _personnelService = personnelService;
        }

        [HttpGet]
        public async Task< IActionResult> Create()
        {
            List<University> reservationList = new List<University>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://universities.hipolabs.com/search?country=Turkey").ConfigureAwait(false))
                {
                    
                   string apiResponse = await response.Content.ReadAsStringAsync(); ;
                    
                   reservationList = JsonConvert.DeserializeObject<List<University>>(apiResponse);
                }
                
            }

            ViewBag.Universies = new SelectList(reservationList.Select(x=>x.name));
            
            return View(new PersonnelModel());
        }
        [HttpPost]
        public async Task<IActionResult> Create(PersonnelModel p)
        {
            var entity = new Personnel
            {
                Id = p.Id,
                Code = p.Code,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Graduation = p.Graduation,
                IdentityNumber = p.IdentityNumber,
                Gender = p.Gender,
                
            };
            _personnelService.Create(entity);
            return Redirect("/Home/List");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            List<University> reservationList = new List<University>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://universities.hipolabs.com/search?country=Turkey").ConfigureAwait(false))
                {

                    string apiResponse = await response.Content.ReadAsStringAsync(); ;

                    reservationList = JsonConvert.DeserializeObject<List<University>>(apiResponse);
                }

            }

            ViewBag.Universies = new SelectList(reservationList.Select(x => x.name));
            
            return View(_personnelService.GetEntity(x=>x.Id==id));
        }
        [HttpPost]
        public IActionResult Edit(Personnel p)
        {
           _personnelService.Update(p);
            return RedirectToAction("list");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var personnel= _personnelService.GetEntity(x=>x.Id==id);
           
            _personnelService.Delete(personnel);
            return RedirectToAction("list");
        }
        public IActionResult List() 
        {
            return View(_personnelService.List(null)); 
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
