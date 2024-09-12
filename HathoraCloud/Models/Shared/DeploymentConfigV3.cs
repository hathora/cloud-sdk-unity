
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
    public class DeploymentConfigV3
    {

        /// <summary>
        /// Additional ports your server listens on.
        /// </summary>
        [SerializeField]
        [JsonProperty("additionalContainerPorts")]
        public List<ContainerPort>? AdditionalContainerPorts { get; set; }

        /// <summary>
        /// System generated id for a build. Can also be user defined when creating a build.
        /// </summary>
        [SerializeField]
        [JsonProperty("buildId")]
        public string BuildId { get; set; } = default!;

        /// <summary>
        /// Default port the server listens on.
        /// </summary>
        [SerializeField]
        [JsonProperty("containerPort")]
        public int ContainerPort { get; set; } = default!;

        /// <summary>
        /// The environment variable that our process will have access to at runtime.
        /// </summary>
        [SerializeField]
        [JsonProperty("env")]
        public List<DeploymentConfigV3Env> Env { get; set; } = default!;

        /// <summary>
        /// Option to shut down processes that have had no new connections or rooms<br/>
        /// 
        /// <remarks>
        /// for five minutes.
        /// </remarks>
        /// </summary>
        [SerializeField]
        [JsonProperty("idleTimeoutEnabled")]
        public bool IdleTimeoutEnabled { get; set; } = default!;

        /// <summary>
        /// The number of cores allocated to your process.
        /// </summary>
        [SerializeField]
        [JsonProperty("requestedCPU")]
        public double RequestedCPU { get; set; } = default!;

        /// <summary>
        /// The amount of memory allocated to your process.
        /// </summary>
        [SerializeField]
        [JsonProperty("requestedMemoryMB")]
        public double RequestedMemoryMB { get; set; } = default!;

        /// <summary>
        /// Governs how many <a href="https://hathora.dev/docs/concepts/hathora-entities#room">rooms</a> can be scheduled in a process.
        /// </summary>
        [SerializeField]
        [JsonProperty("roomsPerProcess")]
        public int RoomsPerProcess { get; set; } = default!;

        /// <summary>
        /// Transport type specifies the underlying communication protocol to the exposed port.
        /// </summary>
        [SerializeField]
        [JsonProperty("transportType")]
        public TransportType TransportType { get; set; } = default!;
    }
}