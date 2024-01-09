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

namespace Oci.DnsService.Models
{
    /// <summary>
    /// The body for defining a new resolver endpoint.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    [JsonConverter(typeof(CreateResolverEndpointDetailsModelConverter))]
    public class CreateResolverEndpointDetails 
    {
        
        /// <value>
        /// The name of the resolver endpoint. Must be unique, case-insensitive, within the resolver.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// The type of resolver endpoint. VNIC is currently the only supported type.
        /// 
        /// </value>
        ///
        public enum EndpointTypeEnum {
            [EnumMember(Value = "VNIC")]
            Vnic
        };

        
        /// <value>
        /// An IP address from which forwarded queries may be sent. For VNIC endpoints, this IP address must be part
        /// of the subnet and will be assigned by the system if unspecified when isForwarding is true.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "forwardingAddress")]
        public string ForwardingAddress { get; set; }
        
        /// <value>
        /// A Boolean flag indicating whether or not the resolver endpoint is for forwarding.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsForwarding is required.")]
        [JsonProperty(PropertyName = "isForwarding")]
        public System.Nullable<bool> IsForwarding { get; set; }
        
        /// <value>
        /// A Boolean flag indicating whether or not the resolver endpoint is for listening.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsListening is required.")]
        [JsonProperty(PropertyName = "isListening")]
        public System.Nullable<bool> IsListening { get; set; }
        
        /// <value>
        /// An IP address to listen to queries on. For VNIC endpoints this IP address must be part of the
        /// subnet and will be assigned by the system if unspecified when isListening is true.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "listeningAddress")]
        public string ListeningAddress { get; set; }
        
    }

    public class CreateResolverEndpointDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateResolverEndpointDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateResolverEndpointDetails);
            var discriminator = jsonObject["endpointType"].Value<string>();
            switch (discriminator)
            {
                case "VNIC":
                    obj = new CreateResolverVnicEndpointDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
