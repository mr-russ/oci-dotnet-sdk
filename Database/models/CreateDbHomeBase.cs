/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details for creating a Database Home.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    [JsonConverter(typeof(CreateDbHomeBaseModelConverter))]
    public class CreateDbHomeBase 
    {
        
        /// <value>
        /// The user-provided name of the Database Home.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the key container that is used as the master encryption key in database transparent data encryption (TDE) operations.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        /// <value>
        /// The OCID of the key container version that is used in database transparent data encryption (TDE) operations KMS Key can have multiple key versions. If none is specified, the current key version (latest) of the Key Id is used for the operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyVersionId")]
        public string KmsKeyVersionId { get; set; }
        
        /// <value>
        /// The database software image [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)
        /// </value>
        [JsonProperty(PropertyName = "databaseSoftwareImageId")]
        public string DatabaseSoftwareImageId { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
                ///
        /// <value>
        /// The source of database: NONE for creating a new database. DB_BACKUP for creating a new database by restoring from a database backup.
        /// 
        /// </value>
        ///
        public enum SourceEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "DB_BACKUP")]
            DbBackup,
            [EnumMember(Value = "DATABASE")]
            Database,
            [EnumMember(Value = "VM_CLUSTER_BACKUP")]
            VmClusterBackup,
            [EnumMember(Value = "VM_CLUSTER_NEW")]
            VmClusterNew
        };

        
        /// <value>
        /// If true, the customer acknowledges that the specified Oracle Database software is an older release that is not currently supported by OCI.
        /// </value>
        [JsonProperty(PropertyName = "isDesupportedVersion")]
        public System.Nullable<bool> IsDesupportedVersion { get; set; }
        
    }

    public class CreateDbHomeBaseModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateDbHomeBase);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateDbHomeBase);
            var discriminator = jsonObject["source"].Value<string>();
            switch (discriminator)
            {
                case "DATABASE":
                    obj = new CreateDbHomeWithDbSystemIdFromDatabaseDetails();
                    break;
                case "DB_BACKUP":
                    obj = new CreateDbHomeWithDbSystemIdFromBackupDetails();
                    break;
                case "VM_CLUSTER_BACKUP":
                    obj = new CreateDbHomeWithVmClusterIdFromBackupDetails();
                    break;
                case "NONE":
                    obj = new CreateDbHomeWithDbSystemIdDetails();
                    break;
                case "VM_CLUSTER_NEW":
                    obj = new CreateDbHomeWithVmClusterIdDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
