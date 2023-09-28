
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace HathoraCloud
{
    using HathoraCloud.Models.Operations;
    using HathoraCloud.Utils;
    using System.Threading.Tasks;
    using System;
    using UnityEngine.Networking;

    /// <summary>
    /// Operations to get logs by <a href="https://hathora.dev/docs/concepts/hathora-entities#application">applications</a>, <a href="https://hathora.dev/docs/concepts/hathora-entities#process">processes</a>, and <a href="https://hathora.dev/docs/concepts/hathora-entities#deployment">deployments</a>. We store 20GB of logs data.
    /// </summary>
    public interface ILogV1SDK
    {

        /// <summary>
        /// Returns a stream of logs for an <a href="https://hathora.dev/docs/concepts/hathora-entities#application">application</a> using `appId`.
        /// </summary>
        Task<GetLogsForAppResponse> GetLogsForAppAsync(GetLogsForAppRequest? request = null);

        /// <summary>
        /// Returns a stream of logs for a <a href="https://hathora.dev/docs/concepts/hathora-entities#deployment">deployment</a> using `appId` and `deploymentId`.
        /// </summary>
        Task<GetLogsForDeploymentResponse> GetLogsForDeploymentAsync(GetLogsForDeploymentRequest? request = null);

        /// <summary>
        /// Returns a stream of logs for a <a href="https://hathora.dev/docs/concepts/hathora-entities#process">process</a> using `appId` and `processId`.
        /// </summary>
        Task<GetLogsForProcessResponse> GetLogsForProcessAsync(GetLogsForProcessRequest? request = null);
    }

    /// <summary>
    /// Operations to get logs by <a href="https://hathora.dev/docs/concepts/hathora-entities#application">applications</a>, <a href="https://hathora.dev/docs/concepts/hathora-entities#process">processes</a>, and <a href="https://hathora.dev/docs/concepts/hathora-entities#deployment">deployments</a>. We store 20GB of logs data.
    /// </summary>
    public class LogV1SDK: ILogV1SDK
    {
        public SDKConfig Config { get; private set; }
        private const string _target = "unity";
        private const string _sdkVersion = "0.19.0";
        private const string _sdkGenVersion = "2.131.1";
        private const string _openapiDocVersion = "0.0.1";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public LogV1SDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
        public async Task<GetLogsForAppResponse> GetLogsForAppAsync(GetLogsForAppRequest? request = null)
        {
            request.AppId ??= Config.AppId;
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/logs/v1/{appId}/all", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbGET);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", $"speakeasy-sdk/{_target} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    var errorMsg = httpResponse.error;
                    httpRequest.Dispose();
                    throw new Exception(errorMsg);
            }

            var contentType = httpResponse.GetResponseHeader("Content-Type");
            
            var response = new GetLogsForAppResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("text/plain",response.ContentType))
                {
                    response.GetLogsForApp200TextPlainByteString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.GetLogsForApp404ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            return response;
        }
        

        [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
        public async Task<GetLogsForDeploymentResponse> GetLogsForDeploymentAsync(GetLogsForDeploymentRequest? request = null)
        {
            request.AppId ??= Config.AppId;
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/logs/v1/{appId}/deployment/{deploymentId}", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbGET);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", $"speakeasy-sdk/{_target} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    var errorMsg = httpResponse.error;
                    httpRequest.Dispose();
                    throw new Exception(errorMsg);
            }

            var contentType = httpResponse.GetResponseHeader("Content-Type");
            
            var response = new GetLogsForDeploymentResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("text/plain",response.ContentType))
                {
                    response.GetLogsForDeployment200TextPlainByteString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.GetLogsForDeployment404ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetLogsForProcessResponse> GetLogsForProcessAsync(GetLogsForProcessRequest? request = null)
        {
            request.AppId ??= Config.AppId;
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/logs/v1/{appId}/process/{processId}", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbGET);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", $"speakeasy-sdk/{_target} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    var errorMsg = httpResponse.error;
                    httpRequest.Dispose();
                    throw new Exception(errorMsg);
            }

            var contentType = httpResponse.GetResponseHeader("Content-Type");
            
            var response = new GetLogsForProcessResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("text/plain",response.ContentType))
                {
                    response.GetLogsForProcess200TextPlainByteString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.GetLogsForProcess404ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 500))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.GetLogsForProcess500ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            return response;
        }
        
    }
}