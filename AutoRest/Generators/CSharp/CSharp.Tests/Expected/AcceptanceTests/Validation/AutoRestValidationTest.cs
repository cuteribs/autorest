// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsValidation
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using Models;

    /// <summary>
    /// Test Infrastructure for AutoRest. No server backend exists for these
    /// tests.
    /// </summary>
    public partial class AutoRestValidationTest : ServiceClient<AutoRestValidationTest>, IAutoRestValidationTest
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }        

        /// <summary>
        /// Subscription ID.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Required string following pattern \\\\d{2}-\\\\d{2}-\\\\d{4}
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// Initializes a new instance of the AutoRestValidationTest class.
        /// </summary>
        public AutoRestValidationTest() : base()
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestValidationTest class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AutoRestValidationTest(params DelegatingHandler[] handlers) : base(handlers)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestValidationTest class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AutoRestValidationTest(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestValidationTest class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AutoRestValidationTest(Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this.Initialize();
            this.BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            this.BaseUri = new Uri("http://localhost");
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver()
            };
            DeserializationSettings = new JsonSerializerSettings{
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver()
            };
        }    
        /// <summary>
        /// Validates input parameters on the method. See swagger for details.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+./// </param>
        /// <param name='id'>
        /// Required int multiple of 10 from 100 to 1000./// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<HttpOperationResponse<Product>> ValidationOfMethodParametersWithHttpMessagesAsync(string resourceGroupName, int? id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (this.SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.SubscriptionId");
            }
            if (resourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "resourceGroupName");
            }
            if (resourceGroupName != null)
            {
                if (resourceGroupName.Length > 10)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "resourceGroupName", 10);
                }
                if (resourceGroupName.Length < 3)
                {
                    throw new ValidationException(ValidationRules.MinLength, "resourceGroupName", 3);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(resourceGroupName, "[a-zA-Z0-9]+"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "resourceGroupName", "[a-zA-Z0-9]+");
                }
            }
            if (id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "id");
            }
            if (id != null)
            {
                if (id > 1000)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "id", 1000);
                }
                if (id < 100)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "id", 100);
                }
                if (id % 10 != 0)
                {
                    throw new ValidationException(ValidationRules.MultipleOf, "id", 10);
                }
            }
            if (this.ApiVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.ApiVersion");
            }
            if (this.ApiVersion != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.ApiVersion, "\\d{2}-\\d{2}-\\d{4}"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "ApiVersion", "\\d{2}-\\d{2}-\\d{4}");
                }
            }
            // Tracing
            bool shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("id", id);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(invocationId, this, "ValidationOfMethodParameters", tracingParameters);
            }
            // Construct URL
            var url = new Uri(this.BaseUri, "fakepath/{subscriptionId}/{resourceGroupName}/{id}?api-version={apiVersion}").ToString();
            url = url.Replace("{subscriptionId}", Uri.EscapeDataString(this.SubscriptionId));
            url = url.Replace("{resourceGroupName}", Uri.EscapeDataString(resourceGroupName));
            url = url.Replace("{id}", Uri.EscapeDataString(JsonConvert.SerializeObject(id, this.SerializationSettings).Trim('"')));
            List<string> queryParameters = new List<string>();
            if (this.ApiVersion != null)
            {
                queryParameters.Add(string.Format("apiVersion={0}", Uri.EscapeDataString(this.ApiVersion)));
            }
            if (queryParameters.Count > 0)
            {
                url += "?" + string.Join("&", queryParameters);
            }
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = new HttpMethod("GET");
            httpRequest.RequestUri = new Uri(url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var header in customHeaders)
                {
                    if (httpRequest.Headers.Contains(header.Key))
                    {
                        httpRequest.Headers.Remove(header.Key);
                    }
                    httpRequest.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
            }

            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            HttpResponseMessage httpResponse = await this.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            HttpStatusCode statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            if (!(statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK")))
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", statusCode));
                string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                Error errorBody = JsonConvert.DeserializeObject<Error>(responseContent, this.DeserializationSettings);
                if (errorBody != null)
                {
                    ex.Body = errorBody;
                }
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }
            // Create Result
            var result = new HttpOperationResponse<Product>();
            result.Request = httpRequest;
            result.Response = httpResponse;
            // Deserialize Response
            if (statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK"))
            {
                string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                result.Body = JsonConvert.DeserializeObject<Product>(responseContent, this.DeserializationSettings);
            }
            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }

        /// <summary>
        /// Validates body parameters on the method. See swagger for details.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+./// </param>
        /// <param name='id'>
        /// Required int multiple of 10 from 100 to 1000./// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<HttpOperationResponse<Product>> ValidationOfBodyWithHttpMessagesAsync(string resourceGroupName, int? id, Product body = default(Product), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (this.SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.SubscriptionId");
            }
            if (resourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "resourceGroupName");
            }
            if (resourceGroupName != null)
            {
                if (resourceGroupName.Length > 10)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "resourceGroupName", 10);
                }
                if (resourceGroupName.Length < 3)
                {
                    throw new ValidationException(ValidationRules.MinLength, "resourceGroupName", 3);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(resourceGroupName, "[a-zA-Z0-9]+"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "resourceGroupName", "[a-zA-Z0-9]+");
                }
            }
            if (id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "id");
            }
            if (id != null)
            {
                if (id > 1000)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "id", 1000);
                }
                if (id < 100)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "id", 100);
                }
                if (id % 10 != 0)
                {
                    throw new ValidationException(ValidationRules.MultipleOf, "id", 10);
                }
            }
            if (body != null)
            {
                body.Validate();
            }
            if (this.ApiVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.ApiVersion");
            }
            if (this.ApiVersion != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.ApiVersion, "\\d{2}-\\d{2}-\\d{4}"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "ApiVersion", "\\d{2}-\\d{2}-\\d{4}");
                }
            }
            // Tracing
            bool shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("id", id);
                tracingParameters.Add("body", body);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(invocationId, this, "ValidationOfBody", tracingParameters);
            }
            // Construct URL
            var url = new Uri(this.BaseUri, "fakepath/{subscriptionId}/{resourceGroupName}/{id}?api-version={apiVersion}").ToString();
            url = url.Replace("{subscriptionId}", Uri.EscapeDataString(this.SubscriptionId));
            url = url.Replace("{resourceGroupName}", Uri.EscapeDataString(resourceGroupName));
            url = url.Replace("{id}", Uri.EscapeDataString(JsonConvert.SerializeObject(id, this.SerializationSettings).Trim('"')));
            List<string> queryParameters = new List<string>();
            if (this.ApiVersion != null)
            {
                queryParameters.Add(string.Format("apiVersion={0}", Uri.EscapeDataString(this.ApiVersion)));
            }
            if (queryParameters.Count > 0)
            {
                url += "?" + string.Join("&", queryParameters);
            }
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = new HttpMethod("PUT");
            httpRequest.RequestUri = new Uri(url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var header in customHeaders)
                {
                    if (httpRequest.Headers.Contains(header.Key))
                    {
                        httpRequest.Headers.Remove(header.Key);
                    }
                    httpRequest.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
            }

            // Serialize Request
            string requestContent = JsonConvert.SerializeObject(body, this.SerializationSettings);
            httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
            httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            HttpResponseMessage httpResponse = await this.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            HttpStatusCode statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            if (!(statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK")))
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", statusCode));
                string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                Error errorBody = JsonConvert.DeserializeObject<Error>(responseContent, this.DeserializationSettings);
                if (errorBody != null)
                {
                    ex.Body = errorBody;
                }
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }
            // Create Result
            var result = new HttpOperationResponse<Product>();
            result.Request = httpRequest;
            result.Response = httpResponse;
            // Deserialize Response
            if (statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK"))
            {
                string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                result.Body = JsonConvert.DeserializeObject<Product>(responseContent, this.DeserializationSettings);
            }
            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }

    }
}
