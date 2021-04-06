/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.ApplicationmigrationService.Models
{
    /// <summary>
    /// Details of the source environment from which you want to migrate applications to Oracle Cloud Infrastructure. It also contains access
    /// credentials.
    /// 
    /// </summary>
    [JsonConverter(typeof(AuthorizationDetailsModelConverter))]
    public class AuthorizationDetails 
    {
        
        
    }

    public class AuthorizationDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(AuthorizationDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(AuthorizationDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "OCC":
                    obj = new OccAuthorizationDetails();
                    break;
                case "INTERNAL_COMPUTE":
                    obj = new InternalAuthorizationDetails();
                    break;
                case "OCIC_IDCS":
                    obj = new OcicAuthorizationTokenDetails();
                    break;
                case "OCIC":
                    obj = new OcicAuthorizationDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
