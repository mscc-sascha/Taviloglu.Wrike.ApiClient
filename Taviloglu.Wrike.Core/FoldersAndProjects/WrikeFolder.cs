﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using Taviloglu.Wrike.Core.Json;

namespace Taviloglu.Wrike.Core
{
    public sealed class WrikeFolder : WrikeObjectWithId
    {
        /// <summary>
        /// Account ID
        /// </summary>
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Created date Format: yyyy-MM-dd'T'HH:mm:ss'Z'
        /// </summary>
       [JsonProperty("createdDate")]
       [JsonConverter(typeof(CustomDateTimeConverter), new object[] { "yyyy-MM-dd'T'HH:mm:ss'Z'" })]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Updated date Format: yyyy-MM-dd'T'HH:mm:ss'Z'
        /// </summary>
       [JsonProperty("updatedDate")]
        [JsonConverter(typeof(CustomDateTimeConverter), new object[] { "yyyy-MM-dd'T'HH:mm:ss'Z'" })]
       
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Brief description
        /// </summary>
        [JsonProperty("briefDescription")]
        public string BriefDescription { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Color 
        /// </summary>
        [JsonProperty("color")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WrikeColor.FolderColor Color { get; set; }

        /// <summary>
        /// List of user IDs, who share the folder
        /// </summary>
        [JsonProperty("sharedIds")]
        public List<string> SharedIds { get; set; }

        /// <summary>
        /// List of parent folder IDs
        /// </summary>
        [JsonProperty("parentIds")]
        public List<string> ParentIds { get; set; }
        /// <summary>
        /// List of child folder IDs
        /// </summary>
        [JsonProperty("childIds")]
        public List<string> ChildIds { get; set; }

        /// <summary>
        /// List of super parent folder IDs
        /// </summary>
        [JsonProperty("superParentIds")]
        public List<string> SuperParentIds { get; set; }

        /// <summary>
        /// Folder scope 
        /// </summary>
        [JsonProperty("scope")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WrikeTreeScope Scope { get; set; }

        /// <summary>
        /// True if folder has attachments
        /// </summary>
        [JsonProperty("hasAttachments")]
        public bool HasAttachments { get; set; }
        /// <summary>
        /// Total count of folder attachments
        /// </summary>
        [JsonProperty("attachmentCount")]
        public string AttachmentCount { get; set; }
        /// <summary>
        /// Link to open folder in web workspace, if user has appropriate access
        /// </summary>
        [JsonProperty("permalink")]
        public string Permalink { get; set; }
        /// <summary>
        /// Folder workflow ID
        /// </summary>
        [JsonProperty("workfloId")]
        public string WorkflowId { get; set; }
        /// <summary>
        /// List of folder metadata entries
        /// </summary>
        [JsonProperty("metadata")]
        public List<WrikeMetadata> Metadata { get; set; }
        /// <summary>
        /// Custom fields
        /// </summary>
        [JsonProperty("customFields")]
        public List<WrikeCustomField> CustomFields { get; set; }
        /// <summary>
        /// Custom column IDs
        /// </summary>
        [JsonProperty("customColumnIds")]
        public List<string> CustomColumnIds { get; set; }

        /// <summary>
        /// Project details, present only for project folders
        /// </summary>
        [JsonProperty("project")]
        public List<WrikeProject> Project { get; set; }

        /// <summary>
        /// Json string array of optional fields to be included in the response model
        /// </summary>
        public class OptionalFields
        {
            /// <summary>
            /// Get brief description
            /// </summary>
            public const string BriefDescription = "briefDescription";
            /// <summary>
            /// Associated custom field IDs
            /// </summary>
            public const string CustomColumnIds = "customColumnIds"; //todo: check if there is an error - returned null not 0
            /// <summary>
            /// Attachment count
            /// </summary>
            public const string AttachmentCount = "attachmentCount";
        }

    }
}
