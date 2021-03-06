# ApiClient

A C# .NET Core API Client library for connecting to and consuming data from APIs.

![.NET Core](https://github.com/jboyer87/ApiClient/workflows/.NET%20Core/badge.svg?branch=master)
![Nuget](https://img.shields.io/nuget/v/ApiClient.Common)

# Installation

Add the `ApiClient.Common` package to your project (depends on the `ApiClient.Utilities` project):

```
dotnet add package ApiClient.Common
```

Follow the usage instructions below to get started.

# Usage

The `ApiClient` library provides several types of connections for different uses.

## Basic Connection

A `BasicConnection` object is appropriate for an API that does not require any authentication.

### Setting up a Basic Connection

1. Set up your configuration object.

   ```
   // Set the URL
   var url = new Uri("https://postman-echo.com"); // The Base URL of the API

   // Configure your response/request types using the built-in `ResponseType` and `RequestType`
   // helpers.
   var responseType = ResponseType.PlainText; // Choose from `Json`, `PlainText`, or `Html` types.
   var requestType = RequestType.Json; // Choose from `Json` or `Form` types.

   // Pass the base URL and response/request types to the `BasicConnectionConfig` constructor.
   var basicConnectionConfig = new BasicConnectionConfig(url, responseType, requestType);
   ```

2. Pass your configuration object to the `ConnectionFactory.GetConnection(...)` method to instantiate a new connection object. The `ConnectionFactory` returns the proper connection type based on the configuration passed in.

   ```
   IConnection basicConnection = ConnectionFactory.GetConnection(basicConnectionConfig);
   ```

3. Send a GET or POST request and save the response in a `Response` object.

   ```
   // For example: Sends a POST request to https://postman-echo.com/post with no additional headers
   // and "This is my body" as the response body.
   Response basicConnectionResponse =
   	basicConnection.Post("/post", null, "This is my body");
   ```

4. Read back the properties inside of your `Response` object. `Message` contains the response message, and `StatusCode` contains the HTTP status code.

   ```
   Console.WriteLine(
   	"**Basic connection test**\n" +
   	String.Format("The status code: {1}\nThe response: {0}",
   	basicConnectionResponse.Message,
   	basicConnectionResponse.StatusCode)
   );
   ```

## Basic Auth Connection

A `BasicAuthConnection` object is appropriate for an API that requires only basic HTTP authentication. Basic HTTP authentication requires sending a Base-64-encoded string that contains an encoded version of the username/password pair. The `BasicAuthConnection` object handles encoding and appending this header to all of your requests.

### Setting up a Basic Auth Connection

This process is very similar to setting up a `BasicConnection` object. This time, we pass additional username and password parameters to the configuration constructor.

1. Set up your configuration object.

   ```
   string username = "postman";
   string password = "password";

   var basicAuthConfig =
   new BasicAuthConnectionConfig(url, responseType, requestType, username, password);
   ```

2. Pass your configuration object to the `ConnectionFactory.GetConnection(...)` method to instantiate a new connection object. The `ConnectionFactory` once again returns the proper connection type based on the configuration passed in.

   ```
   IConnection basicAuthConnection = ConnectionFactory.GetConnection(basicAuthConfig);
   ```

3. Send a GET or POST request and save the response in a `Response` object.

   ```
   // For example: Sends a GET request to https://postman-echo.com/basic-auth with no additional
   // headers and an empty response body.
   Response basicAuthResponse = basicAuthConnection.Get("/basic-auth", null);
   ```

# Contributing

Contributing by creating issues and pull requests is encouraged.

## DOs and DON'Ts

- DO follow the coding style. Look around the codebase and try to mirror what you see.
- DO create issues and foster discussion.
- DO reference issues in your pull request (I.E. "Fixes #123") so that it will be automatically closed when/if the pull request is merged in.
- DO create pull requests against the develop branch.
- DON'T make large surprise pull requests. File an issue and start a discussion. We should work together on a solution before you invest time in a large un-vetted pull request.
- DON'T create pull requests against the master branch.
