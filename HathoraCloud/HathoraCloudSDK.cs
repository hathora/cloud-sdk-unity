
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
    using HathoraCloud.Models.Errors;
    using HathoraCloud.Models.Shared;
    using HathoraCloud.Utils;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Hathora Cloud API: Welcome to the Hathora Cloud API documentation! Learn how to use the Hathora Cloud APIs to build and scale your game servers globally.
    /// </summary>
    public interface IHathoraCloudSDK
    {
        public IAppsV1 AppsV1 { get; }

        /// <summary>
        /// Operations that allow you to generate a Hathora-signed <a href="JWT">JSON web token (JWT)</a> for <a href="https://hathora.dev/docs/lobbies-and-matchmaking/auth-service">player authentication</a>.
        /// </summary>
        public IAuthV1 AuthV1 { get; }

        /// <summary>
        ///  
        /// </summary>
        public IBillingV1 BillingV1 { get; }
        public IBuildsV1 BuildsV1 { get; }
        public IBuildsV2 BuildsV2 { get; }
        public IDeploymentsV1 DeploymentsV1 { get; }
        public IDeploymentsV2 DeploymentsV2 { get; }

        /// <summary>
        /// Deprecated. Does not include latest Regions (missing Dallas region). Use <a href="https://hathora.dev/api#tag/DiscoveryV2">DiscoveryV2</a>.
        /// </summary>
        public IDiscoveryV1 DiscoveryV1 { get; }

        /// <summary>
        /// Service that allows clients to directly ping all Hathora regions to get latency information
        /// </summary>
        public IDiscoveryV2 DiscoveryV2 { get; }
        public ILobbiesV1 LobbiesV1 { get; }
        public ILobbiesV2 LobbiesV2 { get; }
        public ILobbiesV3 LobbiesV3 { get; }
        public ILogsV1 LogsV1 { get; }

        /// <summary>
        ///  
        /// </summary>
        public IManagementV1 ManagementV1 { get; }

        /// <summary>
        /// Operations to get metrics by <a href="https://hathora.dev/docs/concepts/hathora-entities#process">process</a>. We store 72 hours of metrics data.
        /// </summary>
        public IMetricsV1 MetricsV1 { get; }
        public IOrganizationsV1 OrganizationsV1 { get; }

        /// <summary>
        /// Deprecated. Use <a href="https://hathora.dev/api#tag/ProcessesV2">ProcessesV2</a>.
        /// </summary>
        public IProcessesV1 ProcessesV1 { get; }

        /// <summary>
        /// Operations to get data on active and stopped <a href="https://hathora.dev/docs/concepts/hathora-entities#process">processes</a>.
        /// </summary>
        public IProcessesV2 ProcessesV2 { get; }
        public IRoomsV1 RoomsV1 { get; }
        public IRoomsV2 RoomsV2 { get; }

        /// <summary>
        ///  
        /// </summary>
        public ITokensV1 TokensV1 { get; }
    }
    

    public class SDKConfig
    {
        /// <summary>
        /// List of server URLs available to the SDK.
        /// </summary>
        public static readonly string[] ServerList = {
            "https://api.hathora.dev",
            "https:///",
        };

        public string serverUrl = "";
        public int serverIndex = 0;
        public string? AppId;

        public string GetTemplatedServerDetails()
        {
            if (!String.IsNullOrEmpty(this.serverUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.serverUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.serverIndex], new Dictionary<string, string>());
        }
    }

    /// <summary>
    /// Hathora Cloud API: Welcome to the Hathora Cloud API documentation! Learn how to use the Hathora Cloud APIs to build and scale your game servers globally.
    /// </summary>
    public class HathoraCloudSDK: IHathoraCloudSDK
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _target = "unity";
        private const string _sdkVersion = "0.30.0";
        private const string _sdkGenVersion = "2.339.1";
        private const string _openapiDocVersion = "0.0.1";
        private const string _userAgent = "speakeasy-sdk/unity 0.30.0 2.339.1 0.0.1 HathoraCloud";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;
        public IAppsV1 AppsV1 { get; private set; }
        public IAuthV1 AuthV1 { get; private set; }
        public IBillingV1 BillingV1 { get; private set; }
        public IBuildsV1 BuildsV1 { get; private set; }
        public IBuildsV2 BuildsV2 { get; private set; }
        public IDeploymentsV1 DeploymentsV1 { get; private set; }
        public IDeploymentsV2 DeploymentsV2 { get; private set; }
        public IDiscoveryV1 DiscoveryV1 { get; private set; }
        public IDiscoveryV2 DiscoveryV2 { get; private set; }
        public ILobbiesV1 LobbiesV1 { get; private set; }
        public ILobbiesV2 LobbiesV2 { get; private set; }
        public ILobbiesV3 LobbiesV3 { get; private set; }
        public ILogsV1 LogsV1 { get; private set; }
        public IManagementV1 ManagementV1 { get; private set; }
        public IMetricsV1 MetricsV1 { get; private set; }
        public IOrganizationsV1 OrganizationsV1 { get; private set; }
        public IProcessesV1 ProcessesV1 { get; private set; }
        public IProcessesV2 ProcessesV2 { get; private set; }
        public IRoomsV1 RoomsV1 { get; private set; }
        public IRoomsV2 RoomsV2 { get; private set; }
        public ITokensV1 TokensV1 { get; private set; }

        public HathoraCloudSDK(Security? security = null, Func<Security>? securitySource = null, string? appId = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverIndex != null)
            {
                if (serverIndex.Value < 0 || serverIndex.Value >= SDKConfig.ServerList.Length)
                {
                    throw new Exception($"Invalid server index {serverIndex.Value}");
                }
                _serverIndex = serverIndex.Value;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _defaultClient = new SpeakeasyHttpClient(client);

            if(securitySource != null)
            {
                _securitySource = securitySource;
            }
            else if(security != null)
            {
                _securitySource = () => security;
            }

            SDKConfiguration = new SDKConfig()
            {
                AppId = appId,
                serverIndex = _serverIndex,
                serverUrl = _serverUrl
            };

            AppsV1 = new AppsV1(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            AuthV1 = new AuthV1(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            BillingV1 = new BillingV1(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            BuildsV1 = new BuildsV1(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            BuildsV2 = new BuildsV2(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            DeploymentsV1 = new DeploymentsV1(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            DeploymentsV2 = new DeploymentsV2(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            DiscoveryV1 = new DiscoveryV1(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            DiscoveryV2 = new DiscoveryV2(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            LobbiesV1 = new LobbiesV1(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            LobbiesV2 = new LobbiesV2(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            LobbiesV3 = new LobbiesV3(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            LogsV1 = new LogsV1(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            ManagementV1 = new ManagementV1(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            MetricsV1 = new MetricsV1(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            OrganizationsV1 = new OrganizationsV1(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            ProcessesV1 = new ProcessesV1(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            ProcessesV2 = new ProcessesV2(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            RoomsV1 = new RoomsV1(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            RoomsV2 = new RoomsV2(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            TokensV1 = new TokensV1(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}
