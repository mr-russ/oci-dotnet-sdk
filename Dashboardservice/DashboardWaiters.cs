/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.DashboardService.Models;
using Oci.DashboardService.Requests;
using Oci.DashboardService.Responses;

namespace Oci.DashboardService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Dashboard.
    /// </summary>
    public class DashboardWaiters
    {
        private readonly DashboardClient client;

        public  DashboardWaiters(DashboardClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDashboardRequest, GetDashboardResponse> ForDashboard(GetDashboardRequest request, params Dashboard.LifecycleStateEnum[] targetStates)
        {
            return this.ForDashboard(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDashboardRequest, GetDashboardResponse> ForDashboard(GetDashboardRequest request, WaiterConfiguration config, params Dashboard.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetDashboardRequest, GetDashboardResponse>(
                request,
                request => client.GetDashboard(request),
                response => targetStates.Contains(response.Dashboard.LifecycleState.Value),
                targetStates.Contains(Dashboard.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetDashboardRequest, GetDashboardResponse>(config, agent);
        }
    }
}
