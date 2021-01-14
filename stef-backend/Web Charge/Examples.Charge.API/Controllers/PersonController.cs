using System;
using System.Threading.Tasks;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Examples.Charge.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonController : BaseController
	{
		private IPersonFacade _facade;

		public PersonController(IPersonFacade facade)
		{
			_facade = facade;
		}

		[HttpGet]
		public async Task<ActionResult<PersonResponse>> Get()
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
		public async Task<ActionResult<PersonResponse>> GetById(int id)
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
        public async Task<ActionResult<PersonResponse>> Put([FromBody] PersonRequest person)
        {
            try
            {
                var response = Response(await _facade.PutAsync(person));
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
