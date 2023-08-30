using Market.API.Data;
using Market.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Market.API.Controllers
{
    [ApiController]
    [Route("api/countries")]
    public class CountriesController:ControllerBase
    {
        private readonly DataContext _dataContext;
        public CountriesController(DataContext dataContext) 
        {
            _dataContext = dataContext;
        }
        [HttpGet]
        public async Task<ActionResult> Get() {
            return Ok(await _dataContext.Countries.ToListAsync());
                }



        [HttpPost]
        public async Task<ActionResult> Post(Country country)
        {
            _dataContext.Add(country);
            await _dataContext.SaveChangesAsync();
            return Ok(country);
        }

    }
}
