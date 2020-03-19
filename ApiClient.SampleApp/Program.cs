using System;
using ApiClient.Common;

namespace ApiClient.SampleApp
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Hello World!");

			var url = new Uri("https://postman-echo.com");
			var responseType = ResponseType.PlainText;
			var requestType = RequestType.Json;

			var basicConnectionConfig = new BasicConnectionConfig(url, responseType, requestType);

			IConnection basicConnection = ConnectionFactory.GetConnection(basicConnectionConfig);

			Response basicConnectionResponse = 
				basicConnection.Post("/post", null, "This is my body");

			Console.WriteLine(
				"**Basic connection test**\n" +
				String.Format("The status code: {1}\nThe response: {0}",
				basicConnectionResponse.Message,
				basicConnectionResponse.StatusCode)
			);

			string username = "postman";
			string password = "password";

			var basicAuthConfig = 
				new BasicAuthConnectionConfig(url, responseType, requestType, username, password);

			IConnection basicAuthConnection = ConnectionFactory.GetConnection(basicAuthConfig);

			Response basicAuthResponse = basicAuthConnection.Get("/basic-auth", null);

			Console.WriteLine(
				"**Basic authentication connection test**\n" +
				String.Format("The status code: {1}\nThe response: {0}",
				basicAuthResponse.Message,
				basicAuthResponse.StatusCode)
			);
		}
	}
}
