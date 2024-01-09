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


namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// Reqeust for creating Security Rule used in the firewall policy rules.
    /// Security Rules determine whether to block or allow a session based on traffic attributes,
    /// such as  the source and destination IP address, protocol/port, and the HTTP(S) target URL.
    /// 
    /// </summary>
    public class CreateSecurityRuleDetails 
    {
        
        /// <value>
        /// Name for the Security rule, must be unique within the policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Condition is required.")]
        [JsonProperty(PropertyName = "condition")]
        public SecurityRuleMatchCriteria Condition { get; set; }
        
        /// <value>
        /// Types of Action on the Traffic flow.
        /// <br/>
        ///   * ALLOW - Allows the traffic.
        ///   * DROP - Silently drops the traffic, e.g. without sending a TCP reset.
        ///   * REJECT - Rejects the traffic, sending a TCP reset to client and/or server as applicable.
        ///   * INSPECT - Inspects traffic for vulnerability as specified in `inspection`, which may result in rejection.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TrafficActionType> Action { get; set; }
        
        /// <value>
        /// Type of inspection to affect the Traffic flow. This is only applicable if action is INSPECT.
        /// <br/>
        ///   * INTRUSION_DETECTION - Intrusion Detection.
        ///   * INTRUSION_PREVENTION - Intrusion Detection and Prevention. Traffic classified as potentially malicious will be rejected as described in `type`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "inspection")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TrafficInspectionType> Inspection { get; set; }
        
        [JsonProperty(PropertyName = "position")]
        public RulePosition Position { get; set; }
        
    }
}
