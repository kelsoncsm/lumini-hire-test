﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Helper;
using LuminiHireApi.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace Web.Controllers
{

    public class DashboardController : Controller
    {
        CallApi _api = new CallApi();

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public JsonResult PopulationChart()
        {
            var populationList = PopulationDataAccessaLayer.GetCityPopulationList();
            return Json(populationList);
        }
    }
}
