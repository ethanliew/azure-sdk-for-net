// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Class containing stamp capacity information
    /// </summary>
    public partial class StampCapacity
    {
        /// <summary>
        /// Initializes a new instance of the StampCapacity class.
        /// </summary>
        public StampCapacity() { }

        /// <summary>
        /// Initializes a new instance of the StampCapacity class.
        /// </summary>
        public StampCapacity(string name = default(string), long? availableCapacity = default(long?), long? totalCapacity = default(long?), string unit = default(string), ComputeModeOptions? computeMode = default(ComputeModeOptions?), WorkerSizeOptions? workerSize = default(WorkerSizeOptions?), int? workerSizeId = default(int?), bool? excludeFromCapacityAllocation = default(bool?), bool? isApplicableForAllComputeModes = default(bool?), string siteMode = default(string))
        {
            Name = name;
            AvailableCapacity = availableCapacity;
            TotalCapacity = totalCapacity;
            Unit = unit;
            ComputeMode = computeMode;
            WorkerSize = workerSize;
            WorkerSizeId = workerSizeId;
            ExcludeFromCapacityAllocation = excludeFromCapacityAllocation;
            IsApplicableForAllComputeModes = isApplicableForAllComputeModes;
            SiteMode = siteMode;
        }

        /// <summary>
        /// Name of the stamp
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Available capacity (# of machines, bytes of storage etc...)
        /// </summary>
        [JsonProperty(PropertyName = "availableCapacity")]
        public long? AvailableCapacity { get; set; }

        /// <summary>
        /// Total capacity (# of machines, bytes of storage etc...)
        /// </summary>
        [JsonProperty(PropertyName = "totalCapacity")]
        public long? TotalCapacity { get; set; }

        /// <summary>
        /// Name of the unit
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Shared/Dedicated workers. Possible values include: 'Shared',
        /// 'Dedicated', 'Dynamic'
        /// </summary>
        [JsonProperty(PropertyName = "computeMode")]
        public ComputeModeOptions? ComputeMode { get; set; }

        /// <summary>
        /// Size of the machines. Possible values include: 'Default', 'Small',
        /// 'Medium', 'Large'
        /// </summary>
        [JsonProperty(PropertyName = "workerSize")]
        public WorkerSizeOptions? WorkerSize { get; set; }

        /// <summary>
        /// Size Id of machines:
        /// 0 - Small
        /// 1 - Medium
        /// 2 - Large
        /// </summary>
        [JsonProperty(PropertyName = "workerSizeId")]
        public int? WorkerSizeId { get; set; }

        /// <summary>
        /// If true it includes basic sites
        /// Basic sites are not used for capacity allocation.
        /// </summary>
        [JsonProperty(PropertyName = "excludeFromCapacityAllocation")]
        public bool? ExcludeFromCapacityAllocation { get; set; }

        /// <summary>
        /// Is capacity applicable for all sites?
        /// </summary>
        [JsonProperty(PropertyName = "isApplicableForAllComputeModes")]
        public bool? IsApplicableForAllComputeModes { get; set; }

        /// <summary>
        /// Shared or Dedicated
        /// </summary>
        [JsonProperty(PropertyName = "siteMode")]
        public string SiteMode { get; set; }

    }
}
