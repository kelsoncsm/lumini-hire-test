using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuminiHireApi.Data;
using LuminiHireApi.Models;
using LuminiHireApi.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Montreal.IdNet.Administrativo.WebApi.Controllers
{
    [ApiController]
    [Route("api/city")]
    public class CityController : ControllerBase
    {
        /// <summary>
        /// Pesquisar Cartórios.
        /// </summary>
        /// <param name="searchModel"></param>
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<City>>> GetAll([FromServices] DataNetContext context)
        {
            return this.Ok(await context.Citys.ToListAsync());
        }


        [HttpGet]
        [Route("region/{regionName}")]
        public async Task<ActionResult<List<City>>> GetByCampos([FromServices] DataNetContext context, string regionName)
        {

            IQueryable<City> query = context.Citys;

            if (regionName != "")
                query = query.Where(x => EF.Functions.Like(x.Region, "%" + regionName + "%"));


            return this.Ok(await query.ToListAsync());
        }


        /// <summary>
        /// Pesquisar Cartórios.
        /// </summary>
        /// <param name="searchModel"></param>
        [HttpGet]
        [Route("regiao")]
        public async Task<ActionResult<List<City>>> GetPorRegiao([FromServices] DataNetContext context)
        {

            var query = context.Citys
                 .GroupBy(o => new { o.Region })
     .Select(g => new
     {
         Qtd = g.Count(),
         Title = g.Key.Region
     });



            return this.Ok(await query.ToListAsync());
        }





    }
}
