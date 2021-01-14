using System;
using System.Threading.Tasks;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Microsoft.AspNetCore.Mvc;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonPhoneController : BaseController
    {
        private readonly IPersonPhoneFacade _facade;

        public PersonPhoneController(IPersonPhoneFacade facade)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<ActionResult<PhoneNumberTypeResponse>> Get()
        {
            try
            {
                var response = Response(await _facade.FindAllAsync());
                return response;
            }
            catch (Exception ex)
            {
                var result = BadRequest(ex.Message);
                return result;
            }
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<PersonPhoneResponse>> GetById(int id)
        {
            try
            {
                var response = Response(await _facade.FindAllByIdAsync(id));
                return response;
            }
            catch (Exception ex)
            {
                var result = BadRequest(ex.Message);
                return result;
            }
        }

        [HttpPut]
        public async Task<ActionResult<PersonPhoneResponse>> Put([FromBody] PersonPhoneListRequest personPhoneRequest)
        {
            try
            {
                ActionResult<PersonPhoneResponse> response = null;

                foreach (var personPhone in personPhoneRequest.Phones)
	            {
		           response = Response(await _facade.PutAsync(personPhone));
                }
                
                return response;
            }
            catch (Exception ex)
            {
                var result = BadRequest(ex.Message);
                return result;
            }
        }

    }
}
