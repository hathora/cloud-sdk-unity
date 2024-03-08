
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
    using HathoraCloud.Models.Shared;
    using HathoraCloud.Utils;
    using Newtonsoft.Json;
    using System.Threading.Tasks;
    using System;
    using UnityEngine.Networking;

    /// <summary>
    /// Operations to get metrics by <a href="https://hathora.dev/docs/concepts/hathora-entities#process">process</a>. We store 72 hours of metrics data.
    /// </summary>
    public interface IMetricsV1
    {

        /// <summary>
        /// Get metrics for a <a href="https://hathora.dev/docs/concepts/hathora-entities#process">process</a> using `appId` and `processId`.
        /// </summary>
        Task<GetMetricsResponse> GetMetricsAsync(GetMetricsRequest request);
    }

    /// <summary>
    /// Operations to get metrics by <a href="https://hathora.dev/docs/concepts/hathora-entities#process">process</a>. We store 72 hours of metrics data.
    /// </summary>
    public class MetricsV1: IMetricsV1
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _target = "unity";
        private const string _sdkVersion = "0.31.3";
        private const string _sdkGenVersion = "2.279.1";
        private const string _openapiDocVersion = "0.0.1";
        private const string _userAgent = "speakeasy-sdk/unity 0.31.3 2.279.1 0.0.1 hathora-cloud";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public MetricsV1(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        
        public async Task<GetMetricsResponse> GetMetricsAsync(GetMetricsRequest request)
        {
            if (request == null)
            {
                request = new GetMetricsRequest();
            }
            request.AppId ??= SDKConfiguration.AppId;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/metrics/v1/{appId}/process/{processId}", request);

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

            var response = new GetMetricsResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.MetricsResponse = JsonConvert.DeserializeObject<MetricsResponse>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }

                return response;
            }

            if((response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 422) || (response.StatusCode == 500))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ApiError = JsonConvert.DeserializeObject<ApiError>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        
    }
}