
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
    
    [Serializable]
    public class CreateMultipartBuildParams
    {

        /// <summary>
        /// System generated id for a build. Can also be user defined when creating a build.
        /// </summary>
        [SerializeField]
        [JsonProperty("buildId")]
        public string? BuildId { get; set; }

        [SerializeField]
        [JsonProperty("buildSizeInBytes")]
        public double BuildSizeInBytes { get; set; } = default!;

        /// <summary>
        /// Tag to associate an external version with a build. It is accessible via <a href="">`GetBuildInfo()`</a>.
        /// </summary>
        [SerializeField]
        [JsonProperty("buildTag")]
        public string? BuildTag { get; set; }
    }
}