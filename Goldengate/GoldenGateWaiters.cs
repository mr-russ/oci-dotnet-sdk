/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.GoldengateService.Models;
using Oci.GoldengateService.Requests;
using Oci.GoldengateService.Responses;

namespace Oci.GoldengateService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of GoldenGate.
    /// </summary>
    public class GoldenGateWaiters
    {
        private readonly GoldenGateClient client;

        public  GoldenGateWaiters(GoldenGateClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCertificateRequest, GetCertificateResponse> ForCertificate(GetCertificateRequest request, params CertificateLifecycleState[] targetStates)
        {
            return this.ForCertificate(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCertificateRequest, GetCertificateResponse> ForCertificate(GetCertificateRequest request, WaiterConfiguration config, params CertificateLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetCertificateRequest, GetCertificateResponse>(
                request,
                request => client.GetCertificate(request),
                response => targetStates.Contains(response.Certificate.LifecycleState.Value),
                targetStates.Contains(CertificateLifecycleState.Deleted)
            );
            return new Waiter<GetCertificateRequest, GetCertificateResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetConnectionRequest, GetConnectionResponse> ForConnection(GetConnectionRequest request, params Connection.LifecycleStateEnum[] targetStates)
        {
            return this.ForConnection(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetConnectionRequest, GetConnectionResponse> ForConnection(GetConnectionRequest request, WaiterConfiguration config, params Connection.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetConnectionRequest, GetConnectionResponse>(
                request,
                request => client.GetConnection(request),
                response => targetStates.Contains(response.Connection.LifecycleState.Value),
                targetStates.Contains(Connection.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetConnectionRequest, GetConnectionResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetConnectionAssignmentRequest, GetConnectionAssignmentResponse> ForConnectionAssignment(GetConnectionAssignmentRequest request, params ConnectionAssignment.LifecycleStateEnum[] targetStates)
        {
            return this.ForConnectionAssignment(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetConnectionAssignmentRequest, GetConnectionAssignmentResponse> ForConnectionAssignment(GetConnectionAssignmentRequest request, WaiterConfiguration config, params ConnectionAssignment.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetConnectionAssignmentRequest, GetConnectionAssignmentResponse>(
                request,
                request => client.GetConnectionAssignment(request),
                response => targetStates.Contains(response.ConnectionAssignment.LifecycleState.Value)
            );
            return new Waiter<GetConnectionAssignmentRequest, GetConnectionAssignmentResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDatabaseRegistrationRequest, GetDatabaseRegistrationResponse> ForDatabaseRegistration(GetDatabaseRegistrationRequest request, params LifecycleState[] targetStates)
        {
            return this.ForDatabaseRegistration(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDatabaseRegistrationRequest, GetDatabaseRegistrationResponse> ForDatabaseRegistration(GetDatabaseRegistrationRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDatabaseRegistrationRequest, GetDatabaseRegistrationResponse>(
                request,
                request => client.GetDatabaseRegistration(request),
                response => targetStates.Contains(response.DatabaseRegistration.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetDatabaseRegistrationRequest, GetDatabaseRegistrationResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeploymentRequest, GetDeploymentResponse> ForDeployment(GetDeploymentRequest request, params LifecycleState[] targetStates)
        {
            return this.ForDeployment(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeploymentRequest, GetDeploymentResponse> ForDeployment(GetDeploymentRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDeploymentRequest, GetDeploymentResponse>(
                request,
                request => client.GetDeployment(request),
                response => targetStates.Contains(response.Deployment.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetDeploymentRequest, GetDeploymentResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeploymentBackupRequest, GetDeploymentBackupResponse> ForDeploymentBackup(GetDeploymentBackupRequest request, params LifecycleState[] targetStates)
        {
            return this.ForDeploymentBackup(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeploymentBackupRequest, GetDeploymentBackupResponse> ForDeploymentBackup(GetDeploymentBackupRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDeploymentBackupRequest, GetDeploymentBackupResponse>(
                request,
                request => client.GetDeploymentBackup(request),
                response => targetStates.Contains(response.DeploymentBackup.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetDeploymentBackupRequest, GetDeploymentBackupResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeploymentUpgradeRequest, GetDeploymentUpgradeResponse> ForDeploymentUpgrade(GetDeploymentUpgradeRequest request, params LifecycleState[] targetStates)
        {
            return this.ForDeploymentUpgrade(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeploymentUpgradeRequest, GetDeploymentUpgradeResponse> ForDeploymentUpgrade(GetDeploymentUpgradeRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDeploymentUpgradeRequest, GetDeploymentUpgradeResponse>(
                request,
                request => client.GetDeploymentUpgrade(request),
                response => targetStates.Contains(response.DeploymentUpgrade.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetDeploymentUpgradeRequest, GetDeploymentUpgradeResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, params OperationStatus[] targetStates)
        {
            return this.ForWorkRequest(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, WaiterConfiguration config, params OperationStatus[] targetStates)
        {
            var agent = new WaiterAgent<GetWorkRequestRequest, GetWorkRequestResponse>(
                request,
                request => client.GetWorkRequest(request),
                response => targetStates.Contains(response.WorkRequest.Status.Value)
            );
            return new Waiter<GetWorkRequestRequest, GetWorkRequestResponse>(config, agent);
        }
    }
}
