
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace HathoraCloud.Models.Operations
{
    using System;
    using UnityEngine.Networking;
    using UnityEngine;
    
    
    [Serializable]
    public class GetLogsForDeploymentResponse: IDisposable
    {
        [SerializeField]
        public string? ContentType { get; set; } = default!;
        
        /// <summary>
        /// Ok
        /// </summary>
        [SerializeField]
        public string? GetLogsForDeployment200TextPlainByteString { get; set; }
        
        [SerializeField]
        public string? GetLogsForDeployment404ApplicationJSONString { get; set; }
        
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