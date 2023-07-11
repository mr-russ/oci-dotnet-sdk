/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Import metadata object response.
    /// </summary>
    public class ImportRequest 
    {
        
        /// <value>
        /// Import object request key
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The name of the Object Storage Bucket where the objects will be imported from
        /// </value>
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        /// <value>
        /// Name of the zip file from which objects will be imported.
        /// </value>
        [JsonProperty(PropertyName = "fileName")]
        public string FileName { get; set; }
        
        /// <value>
        /// Optional parameter to point to object storage tenancy (if using Object Storage of different tenancy)
        /// </value>
        [JsonProperty(PropertyName = "objectStorageTenancyId")]
        public string ObjectStorageTenancyId { get; set; }
        
        /// <value>
        /// Region of the object storage (if using object storage of different region)
        /// </value>
        [JsonProperty(PropertyName = "objectStorageRegion")]
        public string ObjectStorageRegion { get; set; }
        
        /// <value>
        /// Key of the object inside which all the objects will be imported
        /// </value>
        [JsonProperty(PropertyName = "objectKeyForImport")]
        public string ObjectKeyForImport { get; set; }
        
        [JsonProperty(PropertyName = "importConflictResolution")]
        public ImportConflictResolution ImportConflictResolution { get; set; }
                ///
        /// <value>
        /// Import Objects request status.
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SUCCESSFUL")]
            Successful,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "QUEUED")]
            Queued
        };

        /// <value>
        /// Import Objects request status.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// Name of the user who initiated import request.
        /// </value>
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        
        /// <value>
        /// Number of objects that are imported.
        /// </value>
        [JsonProperty(PropertyName = "totalImportedObjectCount")]
        public System.Nullable<int> TotalImportedObjectCount { get; set; }
        
        /// <value>
        /// Time at which the request started getting processed.
        /// </value>
        [JsonProperty(PropertyName = "timeStartedInMillis")]
        public System.Nullable<long> TimeStartedInMillis { get; set; }
        
        /// <value>
        /// Time at which the request was completely processed.
        /// </value>
        [JsonProperty(PropertyName = "timeEndedInMillis")]
        public System.Nullable<long> TimeEndedInMillis { get; set; }
        
        /// <value>
        /// Contains key of the error
        /// </value>
        [JsonProperty(PropertyName = "errorMessages")]
        public System.Collections.Generic.Dictionary<string, string> ErrorMessages { get; set; }
        
        /// <value>
        /// The array of imported object details.
        /// </value>
        [JsonProperty(PropertyName = "importedObjects")]
        public System.Collections.Generic.List<ImportObjectMetadataSummary> ImportedObjects { get; set; }
        
        /// <value>
        /// Name of the import request.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
    }
}
