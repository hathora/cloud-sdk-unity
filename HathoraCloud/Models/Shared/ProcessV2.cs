
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
    public class ProcessV2
    {

        [SerializeField]
        [JsonProperty("additionalExposedPorts")]
        public List<ExposedPort> AdditionalExposedPorts { get; set; } = default!;

        /// <summary>
        /// System generated unique identifier for an application.
        /// </summary>
        [SerializeField]
        [JsonProperty("appId")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// When the process started being provisioned.
        /// </summary>
        [SerializeField]
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// System generated id for a deployment. Increments by 1.
        /// </summary>
        [SerializeField]
        [JsonProperty("deploymentId")]
        public int DeploymentId { get; set; } = default!;

        [SerializeField]
        [JsonProperty("exposedPort", NullValueHandling = NullValueHandling.Include)]
        public ProcessV2ExposedPort? ExposedPort { get; set; } = default!;

        /// <summary>
        /// System generated unique identifier to a runtime instance of your game server.
        /// </summary>
        [SerializeField]
        [JsonProperty("processId")]
        public string ProcessId { get; set; } = default!;

        [SerializeField]
        [JsonProperty("region")]
        public Region Region { get; set; } = default!;

        /// <summary>
        /// Tracks the number of rooms that have been allocated to the process.
        /// </summary>
        [SerializeField]
        [JsonProperty("roomsAllocated")]
        public int RoomsAllocated { get; set; } = default!;

        /// <summary>
        /// Governs how many <a href="https://hathora.dev/docs/concepts/hathora-entities#room">rooms</a> can be scheduled in a process.
        /// </summary>
        [SerializeField]
        [JsonProperty("roomsPerProcess")]
        public int RoomsPerProcess { get; set; } = default!;

        /// <summary>
        /// When the process bound to the specified port. We use this to determine when we should start billing.
        /// </summary>
        [SerializeField]
        [JsonProperty("startedAt", NullValueHandling = NullValueHandling.Include)]
        public DateTime? StartedAt { get; set; } = default!;

        [SerializeField]
        [JsonProperty("status")]
        public ProcessStatus Status { get; set; } = default!;

        /// <summary>
        /// When the process is issued to stop. We use this to determine when we should stop billing.
        /// </summary>
        [SerializeField]
        [JsonProperty("stoppingAt", NullValueHandling = NullValueHandling.Include)]
        public DateTime? StoppingAt { get; set; } = default!;

        /// <summary>
        /// When the process has been terminated.
        /// </summary>
        [SerializeField]
        [JsonProperty("terminatedAt", NullValueHandling = NullValueHandling.Include)]
        public DateTime? TerminatedAt { get; set; } = default!;
    }
}