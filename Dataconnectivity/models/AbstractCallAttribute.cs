/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// The call attributes.
    /// </summary>
    [JsonConverter(typeof(AbstractCallAttributeModelConverter))]
    public class AbstractCallAttribute 
    {
                ///
        /// <value>
        /// The operation type.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "BIPCALLATTRIBUTE")]
            Bipcallattribute,
            [EnumMember(Value = "GENERIC_REST_CALL_ATTRIBUTE")]
            GenericRestCallAttribute
        };

        
    }

    public class AbstractCallAttributeModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(AbstractCallAttribute);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(AbstractCallAttribute);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "BIPCALLATTRIBUTE":
                    obj = new BipCallAttribute();
                    break;
                case "GENERIC_REST_CALL_ATTRIBUTE":
                    obj = new GenericRestCallAttribute();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
