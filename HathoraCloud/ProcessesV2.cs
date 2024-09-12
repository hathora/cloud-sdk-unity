
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace HathoraCloud
{
    using HathoraCloud.Models.Errors;
    using HathoraCloud.Models.Operations;
    using HathoraCloud.Models.Shared;
    using HathoraCloud.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System;
    using UnityEngine.Networking;

    /// <summary>
    /// Operations to get data on active and stopped <a href="https://hathora.dev/docs/concepts/hathora-entities#process">processes</a>.
    /// </summary>
    public interface IProcessesV2
    {

        /// <summary>
        /// Creates a <a href="https://hathora.dev/docs/concepts/hathora-entities#process">process</a> without a room. Use this to pre-allocate processes ahead of time so that subsequent room assignment via <a href="">CreateRoom()</a> can be instant.
        /// </summary>
        Task<CreateProcessV2DeprecatedResponse> CreateProcessV2DeprecatedAsync(CreateProcessV2DeprecatedRequest request);

        /// <summary>
        /// Retrieve the 10 most recent <a href="https://hathora.dev/docs/concepts/hathora-entities#process">processes</a> objects for an <a href="https://hathora.dev/docs/concepts/hathora-entities#application">application</a>. Filter the array by optionally passing in a `status` or `region`.
        /// </summary>
        Task<GetLatestProcessesV2DeprecatedResponse> GetLatestProcessesV2DeprecatedAsync(GetLatestProcessesV2DeprecatedRequest request);

        /// <summary>
        /// Get details for a <a href="https://hathora.dev/docs/concepts/hathora-entities#process">process</a>.
        /// </summary>
        Task<GetProcessInfoV2DeprecatedResponse> GetProcessInfoV2DeprecatedAsync(GetProcessInfoV2DeprecatedRequest request);

        /// <summary>
        /// Count the number of <a href="https://hathora.dev/docs/concepts/hathora-entities#process">processes</a> objects for an <a href="https://hathora.dev/docs/concepts/hathora-entities#application">application</a>. Filter by optionally passing in a `status` or `region`.
        /// </summary>
        Task<GetProcessesCountExperimentalV2DeprecatedResponse> GetProcessesCountExperimentalV2DeprecatedAsync(GetProcessesCountExperimentalV2DeprecatedRequest request);

        /// <summary>
        /// Stops a <a href="https://hathora.dev/docs/concepts/hathora-entities#process">process</a> immediately.
        /// </summary>
        Task<StopProcessV2DeprecatedResponse> StopProcessV2DeprecatedAsync(StopProcessV2DeprecatedRequest request);
    }

    /// <summary>
    /// Operations to get data on active and stopped <a href="https://hathora.dev/docs/concepts/hathora-entities#process">processes</a>.
    /// </summary>
    public class ProcessesV2: IProcessesV2
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _target = "unity";
        private const string _sdkVersion = "0.30.0";
        private const string _sdkGenVersion = "2.415.0";
        private const string _openapiDocVersion = "0.0.1";
        private const string _userAgent = "speakeasy-sdk/unity 0.30.0 2.415.0 0.0.1 HathoraCloud";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public ProcessesV2(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        
        public async Task<CreateProcessV2DeprecatedResponse> CreateProcessV2DeprecatedAsync(CreateProcessV2DeprecatedRequest request)
        {
            if (request == null)
            {
                request = new CreateProcessV2DeprecatedRequest();
            }
            request.AppId ??= SDKConfiguration.AppId;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/processes/v2/{appId}/create/{region}", request);

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbPOST);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);
            int? errorCode = null;
            string? contentType = null;
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    errorCode = (int)httpRequest.responseCode;
                    contentType = httpRequest.GetResponseHeader("Content-Type");
                    httpRequest.Dispose();
                    break;
                case UnityWebRequest.Result.Success:
                    Console.WriteLine("Success");
                    break;
            }

            if (contentType == null)
            {
                contentType = httpResponse.GetResponseHeader("Content-Type") ?? "application/octet-stream";
            }
            int httpCode = errorCode ?? (int)httpResponse.responseCode;
            var response = new CreateProcessV2DeprecatedResponse
            {
                StatusCode = httpCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (httpCode == 201)
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = JsonConvert.DeserializeObject<ProcessV2>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = Utilities.GetDefaultJsonDeserializers() });
                    response.ProcessV2 = obj;
                }
                else
                {
                throw new SDKException("API error occurred", httpCode, httpResponse.downloadHandler.text, httpResponse);
                }
            }
            else if (new List<int>{401, 402, 404, 422, 429, 500}.Contains(httpCode))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = JsonConvert.DeserializeObject<ApiError>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = Utilities.GetDefaultJsonDeserializers() });
                    throw obj!;
                }
                else
                {
                throw new SDKException("API error occurred", httpCode, httpResponse.downloadHandler.text, httpResponse);
                }
            }
            else if (httpCode >= 400 && httpCode < 500 || httpCode >= 500 && httpCode < 600)
            {
                throw new SDKException("API error occurred", httpCode, httpResponse.downloadHandler.text, httpResponse);
            }
            else
            {
                throw new SDKException("unknown status code received", httpCode, httpResponse.downloadHandler.text, httpResponse);
            }
            return response;
        }

        

        
        public async Task<GetLatestProcessesV2DeprecatedResponse> GetLatestProcessesV2DeprecatedAsync(GetLatestProcessesV2DeprecatedRequest request)
        {
            if (request == null)
            {
                request = new GetLatestProcessesV2DeprecatedRequest();
            }
            request.AppId ??= SDKConfiguration.AppId;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/processes/v2/{appId}/list/latest", request);

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbGET);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);
            int? errorCode = null;
            string? contentType = null;
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    errorCode = (int)httpRequest.responseCode;
                    contentType = httpRequest.GetResponseHeader("Content-Type");
                    httpRequest.Dispose();
                    break;
                case UnityWebRequest.Result.Success:
                    Console.WriteLine("Success");
                    break;
            }

            if (contentType == null)
            {
                contentType = httpResponse.GetResponseHeader("Content-Type") ?? "application/octet-stream";
            }
            int httpCode = errorCode ?? (int)httpResponse.responseCode;
            var response = new GetLatestProcessesV2DeprecatedResponse
            {
                StatusCode = httpCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (httpCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = JsonConvert.DeserializeObject<List<ProcessV2>>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = Utilities.GetDefaultJsonDeserializers() });
                    response.Classes = obj;
                }
                else
                {
                throw new SDKException("API error occurred", httpCode, httpResponse.downloadHandler.text, httpResponse);
                }
            }
            else if (new List<int>{401, 404, 429}.Contains(httpCode))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = JsonConvert.DeserializeObject<ApiError>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = Utilities.GetDefaultJsonDeserializers() });
                    throw obj!;
                }
                else
                {
                throw new SDKException("API error occurred", httpCode, httpResponse.downloadHandler.text, httpResponse);
                }
            }
            else if (httpCode >= 400 && httpCode < 500 || httpCode >= 500 && httpCode < 600)
            {
                throw new SDKException("API error occurred", httpCode, httpResponse.downloadHandler.text, httpResponse);
            }
            else
            {
                throw new SDKException("unknown status code received", httpCode, httpResponse.downloadHandler.text, httpResponse);
            }
            return response;
        }

        

        
        public async Task<GetProcessInfoV2DeprecatedResponse> GetProcessInfoV2DeprecatedAsync(GetProcessInfoV2DeprecatedRequest request)
        {
            if (request == null)
            {
                request = new GetProcessInfoV2DeprecatedRequest();
            }
            request.AppId ??= SDKConfiguration.AppId;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/processes/v2/{appId}/info/{processId}", request);

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbGET);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);
            int? errorCode = null;
            string? contentType = null;
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    errorCode = (int)httpRequest.responseCode;
                    contentType = httpRequest.GetResponseHeader("Content-Type");
                    httpRequest.Dispose();
                    break;
                case UnityWebRequest.Result.Success:
                    Console.WriteLine("Success");
                    break;
            }

            if (contentType == null)
            {
                contentType = httpResponse.GetResponseHeader("Content-Type") ?? "application/octet-stream";
            }
            int httpCode = errorCode ?? (int)httpResponse.responseCode;
            var response = new GetProcessInfoV2DeprecatedResponse
            {
                StatusCode = httpCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (httpCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = JsonConvert.DeserializeObject<ProcessV2>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = Utilities.GetDefaultJsonDeserializers() });
                    response.ProcessV2 = obj;
                }
                else
                {
                throw new SDKException("API error occurred", httpCode, httpResponse.downloadHandler.text, httpResponse);
                }
            }
            else if (new List<int>{401, 404, 429}.Contains(httpCode))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = JsonConvert.DeserializeObject<ApiError>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = Utilities.GetDefaultJsonDeserializers() });
                    throw obj!;
                }
                else
                {
                throw new SDKException("API error occurred", httpCode, httpResponse.downloadHandler.text, httpResponse);
                }
            }
            else if (httpCode >= 400 && httpCode < 500 || httpCode >= 500 && httpCode < 600)
            {
                throw new SDKException("API error occurred", httpCode, httpResponse.downloadHandler.text, httpResponse);
            }
            else
            {
                throw new SDKException("unknown status code received", httpCode, httpResponse.downloadHandler.text, httpResponse);
            }
            return response;
        }

        

        
        public async Task<GetProcessesCountExperimentalV2DeprecatedResponse> GetProcessesCountExperimentalV2DeprecatedAsync(GetProcessesCountExperimentalV2DeprecatedRequest request)
        {
            if (request == null)
            {
                request = new GetProcessesCountExperimentalV2DeprecatedRequest();
            }
            request.AppId ??= SDKConfiguration.AppId;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/processes/v2/{appId}/count", request);

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbGET);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);
            int? errorCode = null;
            string? contentType = null;
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    errorCode = (int)httpRequest.responseCode;
                    contentType = httpRequest.GetResponseHeader("Content-Type");
                    httpRequest.Dispose();
                    break;
                case UnityWebRequest.Result.Success:
                    Console.WriteLine("Success");
                    break;
            }

            if (contentType == null)
            {
                contentType = httpResponse.GetResponseHeader("Content-Type") ?? "application/octet-stream";
            }
            int httpCode = errorCode ?? (int)httpResponse.responseCode;
            var response = new GetProcessesCountExperimentalV2DeprecatedResponse
            {
                StatusCode = httpCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (httpCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = JsonConvert.DeserializeObject<GetProcessesCountExperimentalV2DeprecatedResponseBody>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = Utilities.GetDefaultJsonDeserializers() });
                    response.Object = obj;
                }
                else
                {
                throw new SDKException("API error occurred", httpCode, httpResponse.downloadHandler.text, httpResponse);
                }
            }
            else if (new List<int>{401, 404, 429}.Contains(httpCode))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = JsonConvert.DeserializeObject<ApiError>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = Utilities.GetDefaultJsonDeserializers() });
                    throw obj!;
                }
                else
                {
                throw new SDKException("API error occurred", httpCode, httpResponse.downloadHandler.text, httpResponse);
                }
            }
            else if (httpCode >= 400 && httpCode < 500 || httpCode >= 500 && httpCode < 600)
            {
                throw new SDKException("API error occurred", httpCode, httpResponse.downloadHandler.text, httpResponse);
            }
            else
            {
                throw new SDKException("unknown status code received", httpCode, httpResponse.downloadHandler.text, httpResponse);
            }
            return response;
        }

        

        
        public async Task<StopProcessV2DeprecatedResponse> StopProcessV2DeprecatedAsync(StopProcessV2DeprecatedRequest request)
        {
            if (request == null)
            {
                request = new StopProcessV2DeprecatedRequest();
            }
            request.AppId ??= SDKConfiguration.AppId;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/processes/v2/{appId}/stop/{processId}", request);

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbPOST);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);
            int? errorCode = null;
            string? contentType = null;
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    errorCode = (int)httpRequest.responseCode;
                    contentType = httpRequest.GetResponseHeader("Content-Type");
                    httpRequest.Dispose();
                    break;
                case UnityWebRequest.Result.Success:
                    Console.WriteLine("Success");
                    break;
            }

            if (contentType == null)
            {
                contentType = httpResponse.GetResponseHeader("Content-Type") ?? "application/octet-stream";
            }
            int httpCode = errorCode ?? (int)httpResponse.responseCode;
            var response = new StopProcessV2DeprecatedResponse
            {
                StatusCode = httpCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (httpCode == 204)
            {
            }
            else if (new List<int>{401, 404, 429, 500}.Contains(httpCode))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = JsonConvert.DeserializeObject<ApiError>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = Utilities.GetDefaultJsonDeserializers() });
                    throw obj!;
                }
                else
                {
                throw new SDKException("API error occurred", httpCode, httpResponse.downloadHandler.text, httpResponse);
                }
            }
            else if (httpCode >= 400 && httpCode < 500 || httpCode >= 500 && httpCode < 600)
            {
                throw new SDKException("API error occurred", httpCode, httpResponse.downloadHandler.text, httpResponse);
            }
            else
            {
                throw new SDKException("unknown status code received", httpCode, httpResponse.downloadHandler.text, httpResponse);
            }
            return response;
        }

        
    }
}