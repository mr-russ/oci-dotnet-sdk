/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.MysqlService.Models;
using Oci.MysqlService.Requests;
using Oci.MysqlService.Responses;

namespace Oci.MysqlService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Channels.
    /// </summary>
    public class ChannelsWaiters
    {
        private readonly ChannelsClient client;

        public  ChannelsWaiters(ChannelsClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetChannelRequest, GetChannelResponse> ForChannel(GetChannelRequest request, params Channel.LifecycleStateEnum[] targetStates)
        {
            return this.ForChannel(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetChannelRequest, GetChannelResponse> ForChannel(GetChannelRequest request, WaiterConfiguration config, params Channel.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetChannelRequest, GetChannelResponse>(
                request,
                request => client.GetChannel(request),
                response => targetStates.Contains(response.Channel.LifecycleState.Value),
                targetStates.Contains(Channel.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetChannelRequest, GetChannelResponse>(config, agent);
        }
    }
}
