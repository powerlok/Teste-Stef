using System;
using System.Threading.Tasks;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Response;
using Microsoft.AspNetCore.Mvc;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneNumberTypeController : BaseController
    {
        private readonly IPhoneNumberTypeFacade _facade;

        public PhoneNumberTypeController(IPhoneNumberTypeFacade facade)
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
        public async Task<ActionResult<PhoneNumberTypeResponse>> GetById(int id)
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

    }
}
