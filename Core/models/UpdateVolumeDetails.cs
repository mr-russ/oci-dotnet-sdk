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


namespace Oci.CoreService.Models
{
    
    public class UpdateVolumeDetails 
    {
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
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
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The number of volume performance units (VPUs) that will be applied to this volume per GB,
        /// representing the Block Volume service's elastic performance options.
        /// See [Block Volume Performance Levels](https://docs.cloud.oracle.com/iaas/Content/Block/Concepts/blockvolumeperformance.htm#perf_levels) for more information.
        /// <br/>
        /// Allowed values:
        /// <br/>
        ///   * `0`: Represents Lower Cost option.
        /// <br/>
        ///   * `10`: Represents Balanced option.
        /// <br/>
        ///   * `20`: Represents Higher Performance option.
        ///   
        ///   * `30`-`120`: Represents the Ultra High Performance option.
        /// <br/>
        /// For volumes with the auto-tuned performance feature enabled, this is set to the default (minimum) VPUs/GB.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vpusPerGB")]
        public System.Nullable<long> VpusPerGB { get; set; }
        
        /// <value>
        /// The size to resize the volume to in GBs. Has to be larger than the current size.
        /// </value>
        [JsonProperty(PropertyName = "sizeInGBs")]
        public System.Nullable<long> SizeInGBs { get; set; }
        
        /// <value>
        /// Specifies whether the auto-tune performance is enabled for this volume. This field is deprecated.
        /// Use the `DetachedVolumeAutotunePolicy` instead to enable the volume for detached autotune.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoTuneEnabled")]
        public System.Nullable<bool> IsAutoTuneEnabled { get; set; }
        
        /// <value>
        /// The list of block volume replicas that this volume will be updated to have
        /// in the specified destination availability domains.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "blockVolumeReplicas")]
        public System.Collections.Generic.List<BlockVolumeReplicaDetails> BlockVolumeReplicas { get; set; }
        
    }
}
