
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
    
    /// <summary>
    /// Configure <a href="https://hathora.dev/docs/lobbies-and-matchmaking/auth-service">player authentication</a> for your application. Use Hathora&apos;s built-in auth providers or use your own <a href="https://hathora.dev/docs/lobbies-and-matchmaking/auth-service#custom-auth-provider">custom authentication</a>.
    /// </summary>
    [Serializable]
    public class AuthConfiguration
    {

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [SerializeField]
        [JsonProperty("anonymous")]
        public RecordStringNever? Anonymous { get; set; }
        

        /// <summary>
        /// Enable google auth for your application.
        /// </summary>
        [SerializeField]
        [JsonProperty("google")]
        public Google? Google { get; set; }
        

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [SerializeField]
        [JsonProperty("nickname")]
        public RecordStringNever? Nickname { get; set; }
        
    }
}