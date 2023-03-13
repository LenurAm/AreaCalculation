using AreaCalculation.Model;
using System.Threading.Tasks;

namespace AreaCalculation.Api.Services
{
	public interface ISendEmailService
	{
		Task<bool> SendEmail(Contact contact);
		//Task Execute();
	}
}