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

namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Job details that are specific to the operation type.
    /// 
    /// </summary>
    [JsonConverter(typeof(CreateJobOperationDetailsModelConverter))]
    public class CreateJobOperationDetails 
    {
        
        
        /// <value>
        /// Specifies whether or not to upgrade provider versions.
        /// Within the version constraints of your Terraform configuration, use the latest versions available from the source of Terraform providers.
        /// For more information about this option, see [Dependency Lock File (terraform.io)](https://www.terraform.io/language/files/dependency-lock).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isProviderUpgradeRequired")]
        public System.Nullable<bool> IsProviderUpgradeRequired { get; set; }
        
    }

    public class CreateJobOperationDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateJobOperationDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateJobOperationDetails);
            var discriminator = jsonObject["operation"].Value<string>();
            switch (discriminator)
            {
                case "IMPORT_TF_STATE":
                    obj = new CreateImportTfStateJobOperationDetails();
                    break;
                case "PLAN_ROLLBACK":
                    obj = new CreatePlanRollbackJobOperationDetails();
                    break;
                case "APPLY_ROLLBACK":
                    obj = new CreateApplyRollbackJobOperationDetails();
                    break;
                case "APPLY":
                    obj = new CreateApplyJobOperationDetails();
                    break;
                case "PLAN":
                    obj = new CreatePlanJobOperationDetails();
                    break;
                case "DESTROY":
                    obj = new CreateDestroyJobOperationDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
