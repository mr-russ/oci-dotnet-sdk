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

namespace Oci.DevopsService.Models
{
    /// <summary>
    /// TLS configuration used by build service to verify TLS connection.
    /// </summary>
    [JsonConverter(typeof(TlsVerifyConfigModelConverter))]
    public class TlsVerifyConfig 
    {
                ///
        /// <value>
        /// The type of TLS verification.
        /// </value>
        ///
        public enum TlsVerifyModeEnum {
            [EnumMember(Value = "CA_CERTIFICATE_VERIFY")]
            CaCertificateVerify
        };

        
    }

    public class TlsVerifyConfigModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(TlsVerifyConfig);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(TlsVerifyConfig);
            var discriminator = jsonObject["tlsVerifyMode"].Value<string>();
            switch (discriminator)
            {
                case "CA_CERTIFICATE_VERIFY":
                    obj = new CaCertVerify();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under TlsVerifyConfig! Returning null value.");
            }
            return obj;
        }
    }
}
