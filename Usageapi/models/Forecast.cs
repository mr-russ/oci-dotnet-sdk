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


namespace Oci.UsageapiService.Models
{
    /// <summary>
    /// Forecast configuration of usage/cost.
    /// </summary>
    public class Forecast 
    {
                ///
        /// <value>
        /// BASIC uses the exponential smoothing (ETS) model to project future usage/costs based on history data. The basis for projections is a periodic set of equivalent historical days for which the projection is being made.
        /// </value>
        ///
        public enum ForecastTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "BASIC")]
            Basic
        };

        /// <value>
        /// BASIC uses the exponential smoothing (ETS) model to project future usage/costs based on history data. The basis for projections is a periodic set of equivalent historical days for which the projection is being made.
        /// </value>
        [JsonProperty(PropertyName = "forecastType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ForecastTypeEnum> ForecastType { get; set; }
        
        /// <value>
        /// The forecast start time. Defaults to UTC-1 if not specified.
        /// </value>
        [JsonProperty(PropertyName = "timeForecastStarted")]
        public System.Nullable<System.DateTime> TimeForecastStarted { get; set; }
        
        /// <value>
        /// The forecast end time.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeForecastEnded is required.")]
        [JsonProperty(PropertyName = "timeForecastEnded")]
        public System.Nullable<System.DateTime> TimeForecastEnded { get; set; }
        
    }
}
