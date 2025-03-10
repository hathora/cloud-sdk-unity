
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
    
    [Serializable]
    public class CreateOrgToken
    {

        /// <summary>
        /// Readable name for a token. Must be unique within an organization.
        /// </summary>
        [SerializeField]
        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// If not defined, the token has Admin access.
        /// </summary>
        [SerializeField]
        [JsonProperty("scopes")]
        public Scopes? Scopes { get; set; }
    }
}