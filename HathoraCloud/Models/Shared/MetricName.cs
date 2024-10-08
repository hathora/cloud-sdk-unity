
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
    using Newtonsoft.Json;
    using System;
    using UnityEngine;
    
    /// <summary>
    /// Available metrics to query over time.
    /// </summary>
    public enum MetricName
    {
        [JsonProperty("cpu")]
        Cpu,
        [JsonProperty("memory")]
        Memory,
        [JsonProperty("rate_egress")]
        RateEgress,
        [JsonProperty("total_egress")]
        TotalEgress,
        [JsonProperty("active_connections")]
        ActiveConnections,
    }

    public static class MetricNameExtension
    {
        public static string Value(this MetricName value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static MetricName ToEnum(this string value)
        {
            foreach(var field in typeof(MetricName).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (MetricName)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum MetricName");
        }
    }

}