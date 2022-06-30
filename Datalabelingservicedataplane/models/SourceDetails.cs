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

namespace Oci.DatalabelingservicedataplaneService.Models
{
    /// <summary>
    /// The source information is a polymorphic entity. It captures the details of data used for record creation. The discriminator type must match the dataset's source type. The convention is enforced by the API.
    /// 
    /// </summary>
    [JsonConverter(typeof(SourceDetailsModelConverter))]
    public class SourceDetails 
    {
                ///
        /// <value>
        /// The type of data source.
        /// OBJECT_STORAGE - The source details for an object storage bucket.
        /// 
        /// </value>
        ///
        public enum SourceTypeEnum {
            [EnumMember(Value = "OBJECT_STORAGE")]
            ObjectStorage
        };

        
    }

    public class SourceDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(SourceDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(SourceDetails);
            var discriminator = jsonObject["sourceType"].Value<string>();
            switch (discriminator)
            {
                case "OBJECT_STORAGE":
                    obj = new ObjectStorageSourceDetails();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under SourceDetails! Returning null value.");
            }
            return obj;
        }
    }
}
