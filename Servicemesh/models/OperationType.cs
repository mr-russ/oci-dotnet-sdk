/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.ServicemeshService.Models
{
  /// <summary>
  /// Possible operation types.
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_MESH")]
      CreateMesh,
      [EnumMember(Value = "UPDATE_MESH")]
      UpdateMesh,
      [EnumMember(Value = "DELETE_MESH")]
      DeleteMesh,
      [EnumMember(Value = "MOVE_MESH")]
      MoveMesh,
      [EnumMember(Value = "CREATE_ACCESS_POLICY")]
      CreateAccessPolicy,
      [EnumMember(Value = "UPDATE_ACCESS_POLICY")]
      UpdateAccessPolicy,
      [EnumMember(Value = "DELETE_ACCESS_POLICY")]
      DeleteAccessPolicy,
      [EnumMember(Value = "MOVE_ACCESS_POLICY")]
      MoveAccessPolicy,
      [EnumMember(Value = "CREATE_VIRTUAL_SERVICE")]
      CreateVirtualService,
      [EnumMember(Value = "UPDATE_VIRTUAL_SERVICE")]
      UpdateVirtualService,
      [EnumMember(Value = "DELETE_VIRTUAL_SERVICE")]
      DeleteVirtualService,
      [EnumMember(Value = "MOVE_VIRTUAL_SERVICE")]
      MoveVirtualService,
      [EnumMember(Value = "CREATE_VIRTUAL_SERVICE_ROUTE_TABLE")]
      CreateVirtualServiceRouteTable,
      [EnumMember(Value = "UPDATE_VIRTUAL_SERVICE_ROUTE_TABLE")]
      UpdateVirtualServiceRouteTable,
      [EnumMember(Value = "DELETE_VIRTUAL_SERVICE_ROUTE_TABLE")]
      DeleteVirtualServiceRouteTable,
      [EnumMember(Value = "MOVE_VIRTUAL_SERVICE_ROUTE_TABLE")]
      MoveVirtualServiceRouteTable,
      [EnumMember(Value = "CREATE_VIRTUAL_DEPLOYMENT")]
      CreateVirtualDeployment,
      [EnumMember(Value = "UPDATE_VIRTUAL_DEPLOYMENT")]
      UpdateVirtualDeployment,
      [EnumMember(Value = "DELETE_VIRTUAL_DEPLOYMENT")]
      DeleteVirtualDeployment,
      [EnumMember(Value = "MOVE_VIRTUAL_DEPLOYMENT")]
      MoveVirtualDeployment,
      [EnumMember(Value = "CREATE_INGRESS_GATEWAY")]
      CreateIngressGateway,
      [EnumMember(Value = "UPDATE_INGRESS_GATEWAY")]
      UpdateIngressGateway,
      [EnumMember(Value = "DELETE_INGRESS_GATEWAY")]
      DeleteIngressGateway,
      [EnumMember(Value = "MOVE_INGRESS_GATEWAY")]
      MoveIngressGateway,
      [EnumMember(Value = "CREATE_INGRESS_GATEWAY_ROUTE_TABLE")]
      CreateIngressGatewayRouteTable,
      [EnumMember(Value = "UPDATE_INGRESS_GATEWAY_ROUTE_TABLE")]
      UpdateIngressGatewayRouteTable,
      [EnumMember(Value = "DELETE_INGRESS_GATEWAY_ROUTE_TABLE")]
      DeleteIngressGatewayRouteTable,
      [EnumMember(Value = "MOVE_INGRESS_GATEWAY_ROUTE_TABLE")]
      MoveIngressGatewayRouteTable
  }
}
