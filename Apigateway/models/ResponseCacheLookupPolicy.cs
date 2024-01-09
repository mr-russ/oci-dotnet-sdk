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

namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Base policy for Response Cache lookup.
    /// 
    /// </summary>
    [JsonConverter(typeof(ResponseCacheLookupPolicyModelConverter))]
    public class ResponseCacheLookupPolicy 
    {
                ///
        /// <value>
        /// Type of the Response Cache Store Policy.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "SIMPLE_LOOKUP_POLICY")]
            SimpleLookupPolicy
        };

        
        /// <value>
        /// Whether this policy is currently enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// Set true to allow caching responses where the request has an Authorization header. Ensure you have configured your 
        /// cache key additions to get the level of isolation across authenticated requests that you require.
        /// <br/>
        /// When false, any request with an Authorization header will not be stored in the Response Cache.
        /// <br/>
        /// If using the CustomAuthenticationPolicy then the tokenHeader/tokenQueryParam are also subject to this check.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isPrivateCachingEnabled")]
        public System.Nullable<bool> IsPrivateCachingEnabled { get; set; }
        
    }

    public class ResponseCacheLookupPolicyModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ResponseCacheLookupPolicy);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ResponseCacheLookupPolicy);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "SIMPLE_LOOKUP_POLICY":
                    obj = new SimpleLookupPolicy();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ResponseCacheLookupPolicy! Returning null value.");
            }
            return obj;
        }
    }
}
