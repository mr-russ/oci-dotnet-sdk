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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Details used in a request to update a DRG route table.
    /// <br/>
    /// You can't assign a table to a virtual circuit or IPSec tunnel attachment if there is a static route rule for an RPC attachment.
    /// 
    /// </summary>
    public class UpdateDrgRouteTableDetails 
    {
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the import route distribution used to specify how incoming route advertisements through
        /// referenced attachements are inserted into the DRG route table.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "importDrgRouteDistributionId")]
        public string ImportDrgRouteDistributionId { get; set; }
        
        /// <value>
        /// If you want traffic to be routed using ECMP across your virtual circuits or IPSec tunnels to
        /// your on-prem networks, set this value to true on the route table.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEcmpEnabled")]
        public System.Nullable<bool> IsEcmpEnabled { get; set; }
        
    }
}
