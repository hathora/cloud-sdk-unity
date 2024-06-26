
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
    
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    [Serializable]
    public class RoomWithoutAllocations
    {

        /// <summary>
        /// System generated unique identifier for an application.
        /// </summary>
        [SerializeField]
        [JsonProperty("appId")]
        public string AppId { get; set; } = default!;

        [SerializeField]
        [JsonProperty("currentAllocation", NullValueHandling = NullValueHandling.Include)]
        public RoomWithoutAllocationsCurrentAllocation? CurrentAllocation { get; set; } = default!;

        [SerializeField]
        [JsonProperty("roomConfig", NullValueHandling = NullValueHandling.Include)]
        public string? RoomConfig { get; set; } = default!;

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

        /// <summary>
        /// The allocation status of a room.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// `scheduling`: a process is not allocated yet and the room is waiting to be scheduled<br/>
        /// <br/>
        /// `active`: ready to accept connections<br/>
        /// <br/>
        /// `suspended`: room is unallocated from the process but can be rescheduled later with the same `roomId`<br/>
        /// <br/>
        /// `destroyed`: all associated metadata is deleted
        /// </remarks>
        /// </summary>
        [SerializeField]
        [JsonProperty("status")]
        public RoomStatus Status { get; set; } = default!;
    }
}