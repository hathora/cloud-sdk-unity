
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace HathoraUnitySDK.Models.Operations
{
    using HathoraUnitySDK.Models.Shared;
    using System;
    using UnityEngine.Networking;
    using UnityEngine;
    
    [Serializable]
    public class RunBuildResponse: IDisposable
    {

        [SerializeField]
        public ApiError? ApiError { get; set; }
        

        /// <summary>
        /// HTTP response content type for this operation
        /// </summary>
        [SerializeField]
        public string? ContentType { get; set; } = default!;
        

        /// <summary>
        /// HTTP response status code for this operation
        /// </summary>
        [SerializeField]
        public int StatusCode { get; set; } = default!;
        

        /// <summary>
        /// Raw HTTP response; suitable for custom response parsing
        /// </summary>
        [SerializeField]
        public UnityWebRequest RawResponse { get; set; } = default!;
        

        /// <summary>
        /// Ok
        /// </summary>
        [SerializeField]
        public string? Res { get; set; }
        
        public void Dispose() {
            if (RawResponse != null) {
                RawResponse.Dispose();
            }
        }
    }
}