#nullable enable
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Exercise1.Models;
using Hand_In_2.Data;
using Hand_In_2.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace REST_API.Controllers
{

        [ApiController]
        [Route("[controller]")]
        public class AdultsController : ControllerBase
        {
            private IAdultsService _adultsService;

            public AdultsController(IAdultsService adultsService)
            {
                _adultsService = adultsService;
            }

            [HttpGet]
            public async Task<ActionResult<Adult>> getAllAdults()
            {
                try
                {
                    IList<Adult> adults = _adultsService.getAllAdults();
                        return Ok(adults);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return StatusCode(500, e.Message);
                }
            }

            [HttpPost]
            public async Task<ActionResult<Adult>> addAdult([FromBody] Adult adult)
            {
                try
                {
                    _adultsService.addAdult(adult);
                     return Ok(adult);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return StatusCode(500, e.Message);
                }
                
            }

            [HttpDelete]
            public async Task<ActionResult> removeAdult([FromQuery] string? firstName, [FromQuery] string? lastName)
            {
                try
                {
                    IList<Adult> adults = _adultsService.removeAdult(firstName, lastName);
                    return Ok(adults);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return StatusCode(500, e.Message);
                }
        
               
            }
        }
}