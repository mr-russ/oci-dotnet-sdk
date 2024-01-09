/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.CertificatesmanagementService.Models
{
  /// <summary>
  /// The manner in which the certificate authority (CA) was created, whether it is a root CA generated internally by the service or a subordinate CA issued by another CA that was itself generated internally by the service.
    /// 
  /// </summary>
  public enum CertificateAuthorityConfigType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "ROOT_CA_GENERATED_INTERNALLY")]
      RootCaGeneratedInternally,
      [EnumMember(Value = "SUBORDINATE_CA_ISSUED_BY_INTERNAL_CA")]
      SubordinateCaIssuedByInternalCa
  }
}
