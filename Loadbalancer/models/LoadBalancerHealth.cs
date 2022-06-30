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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// The health status details for the specified load balancer.
    /// <br/>
    /// This object does not explicitly enumerate backend sets with a status of `OK`. However, they are included in the
    /// `totalBackendSetCount` sum.
    /// 
    /// </summary>
    public class LoadBalancerHealth 
    {
                ///
        /// <value>
        /// The overall health status of the load balancer.
        /// <br/>
        /// *  **OK:** All backend sets associated with the load balancer return a status of `OK`.
        /// <br/>
        /// *  **WARNING:** At least one of the backend sets associated with the load balancer returns a status of `WARNING`,
        /// no backend sets return a status of `CRITICAL`, and the load balancer life cycle state is `ACTIVE`.
        /// <br/>
        /// *  **CRITICAL:** One or more of the backend sets associated with the load balancer return a status of `CRITICAL`.
        /// <br/>
        /// *  **UNKNOWN:** If any one of the following conditions is true:
        /// <br/>
        ///     *  The load balancer life cycle state is not `ACTIVE`.
        /// <br/>
        ///     *  No backend sets are defined for the load balancer.
        /// <br/>
        ///     *  More than half of the backend sets associated with the load balancer return a status of `UNKNOWN`, none of the backend
        ///        sets return a status of `WARNING` or `CRITICAL`, and the load balancer life cycle state is `ACTIVE`.
        /// <br/>
        ///     *  The system could not retrieve metrics for any reason.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OK")]
            Ok,
            [EnumMember(Value = "WARNING")]
            Warning,
            [EnumMember(Value = "CRITICAL")]
            Critical,
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        };

        /// <value>
        /// The overall health status of the load balancer.
        /// <br/>
        /// *  **OK:** All backend sets associated with the load balancer return a status of `OK`.
        /// <br/>
        /// *  **WARNING:** At least one of the backend sets associated with the load balancer returns a status of `WARNING`,
        /// no backend sets return a status of `CRITICAL`, and the load balancer life cycle state is `ACTIVE`.
        /// <br/>
        /// *  **CRITICAL:** One or more of the backend sets associated with the load balancer return a status of `CRITICAL`.
        /// <br/>
        /// *  **UNKNOWN:** If any one of the following conditions is true:
        /// <br/>
        ///     *  The load balancer life cycle state is not `ACTIVE`.
        /// <br/>
        ///     *  No backend sets are defined for the load balancer.
        /// <br/>
        ///     *  More than half of the backend sets associated with the load balancer return a status of `UNKNOWN`, none of the backend
        ///        sets return a status of `WARNING` or `CRITICAL`, and the load balancer life cycle state is `ACTIVE`.
        /// <br/>
        ///     *  The system could not retrieve metrics for any reason.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// A list of backend sets that are currently in the `WARNING` health state. The list identifies each backend set by the
        /// friendly name you assigned when you created it.
        /// <br/>
        /// Example: example_backend_set3
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WarningStateBackendSetNames is required.")]
        [JsonProperty(PropertyName = "warningStateBackendSetNames")]
        public System.Collections.Generic.List<string> WarningStateBackendSetNames { get; set; }
        
        /// <value>
        /// A list of backend sets that are currently in the `CRITICAL` health state. The list identifies each backend set by the
        /// friendly name you assigned when you created it.
        /// <br/>
        /// Example: example_backend_set
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CriticalStateBackendSetNames is required.")]
        [JsonProperty(PropertyName = "criticalStateBackendSetNames")]
        public System.Collections.Generic.List<string> CriticalStateBackendSetNames { get; set; }
        
        /// <value>
        /// A list of backend sets that are currently in the `UNKNOWN` health state. The list identifies each backend set by the
        /// friendly name you assigned when you created it.
        /// <br/>
        /// Example: example_backend_set2
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UnknownStateBackendSetNames is required.")]
        [JsonProperty(PropertyName = "unknownStateBackendSetNames")]
        public System.Collections.Generic.List<string> UnknownStateBackendSetNames { get; set; }
        
        /// <value>
        /// The total number of backend sets associated with this load balancer.
        /// <br/>
        /// Example: 4
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalBackendSetCount is required.")]
        [JsonProperty(PropertyName = "totalBackendSetCount")]
        public System.Nullable<int> TotalBackendSetCount { get; set; }
        
    }
}
