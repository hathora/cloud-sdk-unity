
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
    public class DestroyRoomDeprecatedSecurity
    {

        [SerializeField]
        [SpeakeasyMetadata("security:scheme=true,type=http,subType=bearer,name=Authorization")]
        public string HathoraDevToken { get; set; } = default!;
        
    }
}