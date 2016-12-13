// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for SubnetsOperations.
    /// </summary>
    public static partial class SubnetsOperationsExtensions
    {
            /// <summary>
            /// The delete subnet operation deletes the specified subnet.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            public static void Delete(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISubnetsOperations)s).DeleteAsync(resourceGroupName, virtualNetworkName, subnetName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete subnet operation deletes the specified subnet.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, subnetName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The delete subnet operation deletes the specified subnet.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            public static void BeginDelete(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISubnetsOperations)s).BeginDeleteAsync(resourceGroupName, virtualNetworkName, subnetName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete subnet operation deletes the specified subnet.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginDeleteAsync(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, subnetName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Get subnet operation retreives information about the specified subnet.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            public static SubnetInner Get(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, string expand = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISubnetsOperations)s).GetAsync(resourceGroupName, virtualNetworkName, subnetName, expand), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get subnet operation retreives information about the specified subnet.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<SubnetInner> GetAsync(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, string expand = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, subnetName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put Subnet operation creates/updates a subnet in thespecified virtual
            /// network
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='subnetParameters'>
            /// Parameters supplied to the create/update Subnet operation
            /// </param>
            public static SubnetInner CreateOrUpdate(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, SubnetInner subnetParameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISubnetsOperations)s).CreateOrUpdateAsync(resourceGroupName, virtualNetworkName, subnetName, subnetParameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put Subnet operation creates/updates a subnet in thespecified virtual
            /// network
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='subnetParameters'>
            /// Parameters supplied to the create/update Subnet operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<SubnetInner> CreateOrUpdateAsync(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, SubnetInner subnetParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, subnetName, subnetParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put Subnet operation creates/updates a subnet in thespecified virtual
            /// network
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='subnetParameters'>
            /// Parameters supplied to the create/update Subnet operation
            /// </param>
            public static SubnetInner BeginCreateOrUpdate(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, SubnetInner subnetParameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISubnetsOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, virtualNetworkName, subnetName, subnetParameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put Subnet operation creates/updates a subnet in thespecified virtual
            /// network
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='subnetParameters'>
            /// Parameters supplied to the create/update Subnet operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<SubnetInner> BeginCreateOrUpdateAsync(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, SubnetInner subnetParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, subnetName, subnetParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List subnets opertion retrieves all the subnets in a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<SubnetInner> List(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISubnetsOperations)s).ListAsync(resourceGroupName, virtualNetworkName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List subnets opertion retrieves all the subnets in a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<SubnetInner>> ListAsync(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List subnets opertion retrieves all the subnets in a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<SubnetInner> ListNext(this ISubnetsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISubnetsOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List subnets opertion retrieves all the subnets in a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<SubnetInner>> ListNextAsync(this ISubnetsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}