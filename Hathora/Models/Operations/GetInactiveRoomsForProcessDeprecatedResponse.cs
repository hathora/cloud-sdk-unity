
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Hathora.Models.Operations
{
    using Hathora.Models.Shared;
    using System.Collections.Generic;
    using System;
    using UnityEngine.Networking;
    using UnityEngine;
    
    
    [Serializable]
    public class GetInactiveRoomsForProcessDeprecatedResponse: IDisposable
    {
        [SerializeField]
        public string? ContentType { get; set; } = default!;
        
        [SerializeField]
        public string? GetInactiveRoomsForProcessDeprecated404ApplicationJSONString { get; set; }
        
        /// <summary>
        /// Ok
        /// </summary>
        [SerializeField]
        public List<RoomWithoutAllocations>? RoomWithoutAllocations { get; set; }
        
        [SerializeField]
        public int StatusCode { get; set; } = default!;
        
        [SerializeField]
        public UnityWebRequest? RawResponse { get; set; }
        
        public void Dispose() {
            if (RawResponse != null) {
                RawResponse.Dispose();
            }
        }
    }
    
}