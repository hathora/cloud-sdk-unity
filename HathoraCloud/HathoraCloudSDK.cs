
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
    using HathoraCloud.Models.Shared;
    using HathoraCloud.Utils;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System;



    /// <summary>
    /// Hathora Cloud API: Welcome to the Hathora Cloud API documentation! Learn how to use the Hathora Cloud APIs to build and scale your game servers globally.
    /// </summary>
    public interface IHathoraCloudSDK
    {

        /// <summary>
        /// Operations that allow you manage your <a href="https://hathora.dev/docs/concepts/hathora-entities#application">applications</a>.
        /// </summary>
        public IAppV1 AppV1 { get; }

        /// <summary>
        /// Operations that allow you to generate a Hathora-signed <a href="JWT">JSON web token (JWT)</a> for <a href="https://hathora.dev/docs/lobbies-and-matchmaking/auth-service">player authentication</a>.
        /// </summary>
        public IAuthV1 AuthV1 { get; }
        public IBillingV1 BillingV1 { get; }

        /// <summary>
        /// Operations that allow you create and manage your <a href="https://hathora.dev/docs/concepts/hathora-entities#build">builds</a>.
        /// </summary>
        public IBuildV1 BuildV1 { get; }

        /// <summary>
        /// Operations that allow you configure and manage an application&apos;s <a href="https://hathora.dev/docs/concepts/hathora-entities#build">build</a> at runtime.
        /// </summary>
        public IDeploymentV1 DeploymentV1 { get; }

        /// <summary>
        /// Service that allows clients to directly ping all Hathora regions to get latency information
        /// </summary>
        public IDiscoveryV1 DiscoveryV1 { get; }

        /// <summary>
        /// Deprecated. Use <a href="https://hathora.dev/api#tag/LobbyV3">LobbyV3</a>.
        /// </summary>
        public ILobbyV1 LobbyV1 { get; }

        /// <summary>
        /// Deprecated. Use <a href="https://hathora.dev/api#tag/LobbyV3">LobbyV3</a>.
        /// </summary>
        public ILobbyV2 LobbyV2 { get; }

        /// <summary>
        /// Operations to create and manage lobbies using our <a href="https://hathora.dev/docs/lobbies-and-matchmaking/lobby-service">Lobby Service</a>.
        /// </summary>
        public ILobbyV3SDK LobbyV3SDK { get; }

        /// <summary>
        /// Operations to get logs by <a href="https://hathora.dev/docs/concepts/hathora-entities#application">applications</a>, <a href="https://hathora.dev/docs/concepts/hathora-entities#process">processes</a>, and <a href="https://hathora.dev/docs/concepts/hathora-entities#deployment">deployments</a>. We store 20GB of logs data.
        /// </summary>
        public ILogV1 LogV1 { get; }
        public IManagementV1 ManagementV1 { get; }

        /// <summary>
        /// Operations to get metrics by <a href="https://hathora.dev/docs/concepts/hathora-entities#process">process</a>. We store 72 hours of metrics data.
        /// </summary>
        public IMetricsV1 MetricsV1 { get; }

        /// <summary>
        /// Deprecated. Use <a href="https://hathora.dev/api#tag/ProcessesV2">ProcessesV2</a>.
        /// </summary>
        public IProcessesV1 ProcessesV1 { get; }

        /// <summary>
        /// Operations to get data on active and stopped <a href="https://hathora.dev/docs/concepts/hathora-entities#process">processes</a>.
        /// </summary>
        public IProcessesV2 ProcessesV2 { get; }

        /// <summary>
        /// Deprecated. Use <a href="https://hathora.dev/api#tag/RoomV2">RoomV2</a>.
        /// </summary>
        public IRoomV1 RoomV1 { get; }

        /// <summary>
        /// Operations to create, manage, and connect to <a href="https://hathora.dev/docs/concepts/hathora-entities#room">rooms</a>.
        /// </summary>
        public IRoomV2 RoomV2 { get; }
    }
    
    public class SDKConfig
    {
        public static string[] ServerList = new string[]
        {
            "https://api.hathora.dev",
            "https:///",
        };
        /// Contains the list of servers available to the SDK
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
        private const string _sdkVersion = "0.28.4";
        private const string _sdkGenVersion = "2.239.0";
        private const string _openapiDocVersion = "0.0.1";
        private const string _userAgent = "speakeasy-sdk/unity 0.28.4 2.239.0 0.0.1 hathora-cloud";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IAppV1 AppV1 { get; private set; }
        public IAuthV1 AuthV1 { get; private set; }
        public IBillingV1 BillingV1 { get; private set; }
        public IBuildV1 BuildV1 { get; private set; }
        public IDeploymentV1 DeploymentV1 { get; private set; }
        public IDiscoveryV1 DiscoveryV1 { get; private set; }
        public ILobbyV1 LobbyV1 { get; private set; }
        public ILobbyV2 LobbyV2 { get; private set; }
        public ILobbyV3SDK LobbyV3SDK { get; private set; }
        public ILogV1 LogV1 { get; private set; }
        public IManagementV1 ManagementV1 { get; private set; }
        public IMetricsV1 MetricsV1 { get; private set; }
        public IProcessesV1 ProcessesV1 { get; private set; }
        public IProcessesV2 ProcessesV2 { get; private set; }
        public IRoomV1 RoomV1 { get; private set; }
        public IRoomV2 RoomV2 { get; private set; }

        public HathoraCloudSDK(Security? security = null, string? appId = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverUrl != null) {
                if (urlParams != null) {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            SDKConfiguration = new SDKConfig()
            {
                AppId = appId,
                serverUrl = _serverUrl
            };

            AppV1 = new AppV1(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            AuthV1 = new AuthV1(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            BillingV1 = new BillingV1(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            BuildV1 = new BuildV1(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            DeploymentV1 = new DeploymentV1(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            DiscoveryV1 = new DiscoveryV1(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            LobbyV1 = new LobbyV1(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            LobbyV2 = new LobbyV2(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            LobbyV3SDK = new LobbyV3SDK(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            LogV1 = new LogV1(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            ManagementV1 = new ManagementV1(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            MetricsV1 = new MetricsV1(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            ProcessesV1 = new ProcessesV1(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            ProcessesV2 = new ProcessesV2(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            RoomV1 = new RoomV1(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            RoomV2 = new RoomV2(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
        }
    }
}