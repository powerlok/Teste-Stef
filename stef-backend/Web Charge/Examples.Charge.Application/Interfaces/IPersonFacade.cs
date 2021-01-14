using System.Threading.Tasks;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;

namespace Examples.Charge.Application.Interfaces
{
	public interface IPersonFacade
    {
	    Task<PersonResponse> FindAllAsync();
	    Task<PersonObjectResponse> FindAllByIdAsync(int businessEntityId);
	    Task<PersonObjectResponse> PutAsync(PersonRequest person);
    }
}