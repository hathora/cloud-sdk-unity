
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
    using HathoraUnitySDK.Utils;
    using System;
    using UnityEngine;
    
    [Serializable]
    public class RunBuildRequestBody
    {

        [SerializeField]
        [SpeakeasyMetadata("multipartForm:file")]
        public File File { get; set; } = default!;
        
    }
}