using System.Threading.Tasks;
using Examples.Charge.Application.Common.Messages;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;

namespace Examples.Charge.Application.Interfaces
{
	public interface IPersonPhoneFacade
	{
		Task<PersonPhoneResponse> FindAllAsync();
		Task<PersonPhoneResponse> FindAllByIdAsync(int businessEntityID);
		Task<PersonPhoneResponse> PutAsync(PersonPhoneRequest person);
	}
}
