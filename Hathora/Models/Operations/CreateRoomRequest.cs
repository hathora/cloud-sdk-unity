
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
    using Hathora.Utils;
    using System;
    using UnityEngine;
    
    
    [Serializable]
    public class CreateRoomRequest
    {
        [SerializeField]
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Models.Shared.CreateRoomRequest CreateRoomRequestValue { get; set; } = default!;
        
        [SerializeField]
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=appId")]
        public string AppId { get; set; } = default!;
        
        [SerializeField]
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=roomId")]
        public string? RoomId { get; set; }
        
    }
    
}