
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
    using HathoraCloud.Utils;
    using System;
    using UnityEngine;
    
    [Serializable]
    public class GetBuildInfoRequest
    {

        [SerializeField]
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=appId")]
        public string AppId { get; set; } = default!;
        

        [SerializeField]
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=buildId")]
        public int BuildId { get; set; } = default!;
        
    }
}