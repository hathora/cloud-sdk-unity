
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
    using System.Collections.Generic;
    using System;
    using UnityEngine;
    
    [Serializable]
    public class CreateRoomParams
    {

        /// <summary>
        /// An optional list of client IP addresses to whitelist for DDoS protection.
        /// </summary>
        [SerializeField]
        [JsonProperty("clientIPs")]
        public List<string>? ClientIPs { get; set; }

        /// <summary>
        /// System generated id for a deployment.
        /// </summary>
        [SerializeField]
        [JsonProperty("deploymentId")]
        public string? DeploymentId { get; set; }

        [SerializeField]
        [JsonProperty("region")]
        public Region Region { get; set; } = default!;

        /// <summary>
        /// Optional configuration parameters for the room. Can be any string including stringified JSON. It is accessible from the room via <a href="">`GetRoomInfo()`</a>.
        /// </summary>
        [SerializeField]
        [JsonProperty("roomConfig")]
        public string? RoomConfig { get; set; }
    }
}