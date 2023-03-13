using AreaCalculation.Model;
using System.Threading.Tasks;

namespace AreaCalculation
{
	public interface IEmailService
	{
		Task<bool> SendEmail(Contact contactForm);
	}
}