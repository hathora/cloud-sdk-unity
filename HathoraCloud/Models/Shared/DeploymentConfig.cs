
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
    
    /// <summary>
    /// User specified deployment configuration for your application at runtime.
    /// </summary>
    [Serializable]
    public class DeploymentConfig
    {

        /// <summary>
        /// Additional ports your server listens on.
        /// </summary>
        [SerializeField]
        [JsonProperty("additionalContainerPorts")]
        public List<ContainerPort>? AdditionalContainerPorts { get; set; }

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
        public List<Env> Env { get; set; } = default!;

        /// <summary>
        /// Option to shut down processes that have had no new connections or rooms<br/>
        /// 
        /// <remarks>
        /// for five minutes.
        /// </remarks>
        /// </summary>
        [SerializeField]
        [JsonProperty("idleTimeoutEnabled")]
        public bool? IdleTimeoutEnabled { get; set; }

        /// <summary>
        /// A plan defines how much CPU and memory is required to run an instance of your game server.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// `tiny`: shared core, 1gb memory<br/>
        /// <br/>
        /// `small`: 1 core, 2gb memory<br/>
        /// <br/>
        /// `medium`: 2 core, 4gb memory<br/>
        /// <br/>
        /// `large`: 4 core, 8gb memory
        /// </remarks>
        /// </summary>
        [SerializeField]
        [JsonProperty("planName")]
        public PlanName PlanName { get; set; } = default!;

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