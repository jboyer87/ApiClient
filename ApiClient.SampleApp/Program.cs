using System;
using ApiClient.Common;

namespace ApiClient.SampleApp
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Hello World!");

			string url = "https://postman-echo.com";
			var responseType = ResponseType.PlainText;
			var requestType = RequestType.Json;

			var config = new BasicConnectionConfig(url, responseType, requestType);

			var connection = new BasicConnection(config);

			Response response = connection.Post("/post", null, "This is my body");

			Console.WriteLine(
				String.Format("The status code: {1}\nThe response: {0}", 
				response.Message, 
				response.StatusCode)
			);
		}
	}
}
