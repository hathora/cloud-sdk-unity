
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
    using HathoraUnitySDK.Utils;
    using System;
    using UnityEngine;
    
    [Serializable]
    public class GetStoppedProcessesRequest
    {

        [SerializeField]
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=appId")]
        public string? AppId { get; set; }
        

        [SerializeField]
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=region")]
        public Region? Region { get; set; }
        
    }
}