
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
    public class CreateLobbyParams
    {

        /// <summary>
        /// User input to initialize the game state. Object must be smaller than 64KB.
        /// </summary>
        [SerializeField]
        [JsonProperty("initialConfig")]
        public object InitialConfig { get; set; } = default!;

        [SerializeField]
        [JsonProperty("region")]
        public Region Region { get; set; } = default!;

        /// <summary>
        /// Types of lobbies a player can create.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// `private`: the player who created the room must share the roomId with their friends<br/>
        /// <br/>
        /// `public`: visible in the public lobby list, anyone can join<br/>
        /// <br/>
        /// `local`: for testing with a server running locally
        /// </remarks>
        /// </summary>
        [SerializeField]
        [JsonProperty("visibility")]
        public LobbyVisibility Visibility { get; set; } = default!;
    }
}