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
    /// Input to perform connector validation. Defines the data integration semantics in a data flow. It can be about reading, writing, or transforming the data.
    /// </summary>
    [JsonConverter(typeof(CreateConnectivityValidationDetailsModelConverter))]
    public class CreateConnectivityValidationDetails 
    {
                ///
        /// <value>
        /// The model type of the operator.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "SOURCE_OPERATOR")]
            SourceOperator,
            [EnumMember(Value = "TARGET_OPERATOR")]
            TargetOperator
        };

        
        /// <value>
        /// The key of the object.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The model version of an object.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
        
        /// <value>
        /// Free form text without any restriction on the permitted characters. Name can have letters, numbers, and special characters. The value is editable and is restricted to 1000 characters.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Details about the operator.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The version of the object that is used to track changes in the object instance.
        /// </value>
        [JsonProperty(PropertyName = "objectVersion")]
        public System.Nullable<int> ObjectVersion { get; set; }
        
        /// <value>
        /// An array of input ports.
        /// </value>
        [JsonProperty(PropertyName = "inputPorts")]
        public System.Collections.Generic.List<InputPort> InputPorts { get; set; }
        
        /// <value>
        /// An array of output ports.
        /// </value>
        [JsonProperty(PropertyName = "outputPorts")]
        public System.Collections.Generic.List<OutputPort> OutputPorts { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        /// <value>
        /// Value can only contain upper case letters, underscore, and numbers. It should begin with an upper case letter or underscore. The value can be modified.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// An array of parameters used in the data flow.
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<Parameter> Parameters { get; set; }
        
        [JsonProperty(PropertyName = "opConfigValues")]
        public ConfigValues OpConfigValues { get; set; }
        
    }

    public class CreateConnectivityValidationDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateConnectivityValidationDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateConnectivityValidationDetails);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "TARGET_OPERATOR":
                    obj = new Target();
                    break;
                case "SOURCE_OPERATOR":
                    obj = new Source();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
