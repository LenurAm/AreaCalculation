using AreaCalculation.Model;
using AreaCalculation;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AreaCalculation
{
	public class EmailService : IEmailService
	{
		private readonly HttpClient _client;
		public EmailService(HttpClient client)
		{
			_client = client ?? throw new ArgumentNullException(nameof(client));
		}

		public async Task<bool> SendEmail(Contact contact)
		{
			using HttpContent requestBody = new StringContent(JsonConvert.SerializeObject(contact));
			requestBody.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //Uri requestUri = new Uri($"api/sendemail/contact", UriKind.Relative);
            Uri requestUri = new Uri($"https://api.sendinblue.com/v3/smtp/email", UriKind.Relative);
            var response = await _client.PostAsync(requestUri, requestBody).ConfigureAwait(false);

			if (response.IsSuccessStatusCode)
			{
				return true;
			}
			return false;
		}
	}
}
