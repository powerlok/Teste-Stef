using System.Threading.Tasks;
using Examples.Charge.Application.Common.Messages;
using Examples.Charge.Application.Messages.Response;

namespace Examples.Charge.Application.Interfaces
{
	public interface IPhoneNumberTypeFacade
	{
		Task<PhoneNumberTypeResponse> FindAllAsync();
        Task<PhoneNumberTypeResponse> FindAllByIdAsync(int phoneNumberTypeId);
    }
}
