
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
    using System;
    using UnityEngine;
    
    [Serializable]
    public class Env
    {

        [SerializeField]
        [JsonProperty("name")]
        public string Name { get; set; } = default!;
        

        [SerializeField]
        [JsonProperty("value")]
        public string Value { get; set; } = default!;
        
    }
}