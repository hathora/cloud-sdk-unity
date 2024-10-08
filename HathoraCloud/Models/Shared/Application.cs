
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace HathoraCloud.Models.Shared
{
    using HathoraCloud.Models.Shared;
    using Newtonsoft.Json;
    using System;
    using UnityEngine;
    
    /// <summary>
    /// An application object is the top level namespace for the game server.
    /// </summary>
    [Serializable]
    public class Application
    {

        /// <summary>
        /// System generated unique identifier for an application.
        /// </summary>
        [SerializeField]
        [JsonProperty("appId")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// Readable name for an application. Must be unique within an organization.
        /// </summary>
        [SerializeField]
        [JsonProperty("appName")]
        public string AppName { get; set; } = default!;

        /// <summary>
        /// Secret that is used for identity and access management.
        /// </summary>
        [SerializeField]
        [JsonProperty("appSecret")]
        public string AppSecret { get; set; } = default!;

        /// <summary>
        /// Configure <a href="https://hathora.dev/docs/lobbies-and-matchmaking/auth-service">player authentication</a> for your application. Use Hathora&apos;s built-in auth providers or use your own <a href="https://hathora.dev/docs/lobbies-and-matchmaking/auth-service#custom-auth-provider">custom authentication</a>.
        /// </summary>
        [SerializeField]
        [JsonProperty("authConfiguration")]
        public AuthConfiguration AuthConfiguration { get; set; } = default!;

        /// <summary>
        /// When the application was created.
        /// </summary>
        [SerializeField]
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; } = default!;

        [SerializeField]
        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// When the application was deleted.
        /// </summary>
        [SerializeField]
        [JsonProperty("deletedAt", NullValueHandling = NullValueHandling.Include)]
        public DateTime? DeletedAt { get; set; } = default!;

        /// <summary>
        /// The email address or token id for the user that deleted the application.
        /// </summary>
        [SerializeField]
        [JsonProperty("deletedBy", NullValueHandling = NullValueHandling.Include)]
        public string? DeletedBy { get; set; } = default!;

        /// <summary>
        /// System generated unique identifier for an organization. Not guaranteed to have a specific format.
        /// </summary>
        [SerializeField]
        [JsonProperty("orgId")]
        public string OrgId { get; set; } = default!;
    }
}