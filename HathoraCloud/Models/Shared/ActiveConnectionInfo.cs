
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
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
    
    [Serializable]
    public class ActiveConnectionInfo
    {

        [SerializeField]
        [JsonProperty("host")]
        public string Host { get; set; } = default!;

        [SerializeField]
        [JsonProperty("port")]
        public double Port { get; set; } = default!;

        /// <summary>
        /// Unique identifier to a game session or match. Use the default system generated ID or overwrite it with your own.<br/>
        /// 
        /// <remarks>
        /// Note: error will be returned if `roomId` is not globally unique.
        /// </remarks>
        /// </summary>
        [SerializeField]
        [JsonProperty("roomId")]
        public string RoomId { get; set; } = default!;

        [SerializeField]
        [JsonProperty("status")]
        public Status Status { get; set; } = default!;

        /// <summary>
        /// Transport type specifies the underlying communication protocol to the exposed port.
        /// </summary>
        [SerializeField]
        [JsonProperty("transportType")]
        public TransportType TransportType { get; set; } = default!;
    }
}