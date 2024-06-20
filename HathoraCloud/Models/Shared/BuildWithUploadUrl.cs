
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
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
    using System.Collections.Generic;
    using System;
    using UnityEngine;
    
    /// <summary>
    /// A build represents a game server artifact and its associated metadata.
    /// </summary>
    [Serializable]
    public class BuildWithUploadUrl
    {

        /// <summary>
        /// System generated unique identifier for an application.
        /// </summary>
        [SerializeField]
        [JsonProperty("appId")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// System generated id for a build. Increments by 1.
        /// </summary>
        [SerializeField]
        [JsonProperty("buildId")]
        public int BuildId { get; set; } = default!;

        [SerializeField]
        [JsonProperty("buildTag")]
        public string? BuildTag { get; set; }

        /// <summary>
        /// When <a href="">`CreateBuild()`</a> is called.
        /// </summary>
        [SerializeField]
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// UserId or email address for the user that created the build.
        /// </summary>
        [SerializeField]
        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// When the build was deleted.
        /// </summary>
        [SerializeField]
        [JsonProperty("deletedAt", NullValueHandling = NullValueHandling.Include)]
        public DateTime? DeletedAt { get; set; } = default!;

        /// <summary>
        /// When <a href="">`RunBuild()`</a> finished executing.
        /// </summary>
        [SerializeField]
        [JsonProperty("finishedAt", NullValueHandling = NullValueHandling.Include)]
        public DateTime? FinishedAt { get; set; } = default!;

        /// <summary>
        /// The size (in bytes) of the Docker image built by Hathora.
        /// </summary>
        [SerializeField]
        [JsonProperty("imageSize")]
        public long ImageSize { get; set; } = default!;

        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [SerializeField]
        [JsonProperty("regionalContainerTags")]
        public List<BuildWithUploadUrlRegionalContainerTags> RegionalContainerTags { get; set; } = default!;

        /// <summary>
        /// When <a href="">`RunBuild()`</a> is called.
        /// </summary>
        [SerializeField]
        [JsonProperty("startedAt", NullValueHandling = NullValueHandling.Include)]
        public DateTime? StartedAt { get; set; } = default!;

        [SerializeField]
        [JsonProperty("status")]
        public BuildStatus Status { get; set; } = default!;

        [SerializeField]
        [JsonProperty("uploadBodyParams")]
        public List<UploadBodyParams> UploadBodyParams { get; set; } = default!;

        [SerializeField]
        [JsonProperty("uploadUrl")]
        public string UploadUrl { get; set; } = default!;
    }
}