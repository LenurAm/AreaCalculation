
using AreaCalculation.Model;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;

namespace AreaCalculation.Api.Services
{
	public class SendEmailService /*: ISendEmailService*/
    {
		//private readonly ISendGridClient _sendGridClient;

		//public SendEmailService(ISendGridClient sendGridClient)
		//{
		//	_sendGridClient = sendGridClient ?? throw new ArgumentNullException(nameof(sendGridClient));
		//}

		//public async Task<bool> SendEmail(Contact contact)
		//{
		//	SendGridMessage msg = new SendGridMessage();
		//	EmailAddress from = new EmailAddress(contact.Email, contact.Name);
		//	//EmailAddress from = new EmailAddress(contact.Email, contact.Name);
		//	//List<EmailAddress> recipients = new List<EmailAddress> { new EmailAddress("your@email.com", "Your Name") };
		//	List<EmailAddress> recipients = new List<EmailAddress> { new EmailAddress("evulet2.08@gmail.com", "Lenar") };
		//	msg.SetSubject("A new user has registered");
		//	msg.SetFrom(from);
		//	msg.AddTos(recipients);
		//	msg.PlainTextContent = contact.Message;
		//	//var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
		//	//msg = MailHelper.CreateSingleEmail(from, recipients[0], contact.Email, contact.Message, htmlContent);
		//	Response response = await _sendGridClient.SendEmailAsync(msg);
		//	if (Convert.ToInt32(response.StatusCode) >= 400)
		//	{
		//		return false;
		//	}
		//	//await Execute();
		//	return true;
		//}
		//public async Task Execute()
		//{
		//	var apiKey = "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";
		//	var client = new SendGridClient(apiKey);
		//	var from = new EmailAddress("evulet2.08@gmail.com", "Lenar");
		//	var subject = "Sending with SendGrid is Fun";
		//	var to = new EmailAddress("evulet2.08@gmail.com", "Lenar");
		//	var plainTextContent = "and easy to do anywhere, even with C#";
		//	var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
		//	var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
		//	var response = await client.SendEmailAsync(msg);
		//}
	}
}
