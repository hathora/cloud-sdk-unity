
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace HathoraUnitySDK.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    using UnityEngine;
    
    /// <summary>
    /// Construct a type with a set of properties K of type T
    /// </summary>
    [Serializable]
    public class MetricsResponse
    {

        [SerializeField]
        [JsonProperty("active_connections")]
        public List<MetricValue>? ActiveConnections { get; set; }
        

        [SerializeField]
        [JsonProperty("cpu")]
        public List<MetricValue>? Cpu { get; set; }
        

        [SerializeField]
        [JsonProperty("memory")]
        public List<MetricValue>? Memory { get; set; }
        

        [SerializeField]
        [JsonProperty("rate_egress")]
        public List<MetricValue>? RateEgress { get; set; }
        

        [SerializeField]
        [JsonProperty("total_egress")]
        public List<MetricValue>? TotalEgress { get; set; }
        
    }
}