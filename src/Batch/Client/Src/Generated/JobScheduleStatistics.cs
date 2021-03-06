// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Resource usage statistics for a <see cref="CloudJobSchedule"/>.
    /// </summary>
    public partial class JobScheduleStatistics : IPropertyMetadata
    {
        private readonly long failedTaskCount;
        private readonly TimeSpan kernelCpuTime;
        private readonly DateTime lastUpdateTime;
        private readonly double readIOGiB;
        private readonly long readIOps;
        private readonly DateTime startTime;
        private readonly long succeededTaskCount;
        private readonly long taskRetryCount;
        private readonly string url;
        private readonly TimeSpan userCpuTime;
        private readonly TimeSpan waitTime;
        private readonly TimeSpan wallClockTime;
        private readonly double writeIOGiB;
        private readonly long writeIOps;

        #region Constructors

        internal JobScheduleStatistics(Models.JobScheduleStatistics protocolObject)
        {
            this.failedTaskCount = protocolObject.NumFailedTasks;
            this.kernelCpuTime = protocolObject.KernelCPUTime;
            this.lastUpdateTime = protocolObject.LastUpdateTime;
            this.readIOGiB = protocolObject.ReadIOGiB;
            this.readIOps = protocolObject.ReadIOps;
            this.startTime = protocolObject.StartTime;
            this.succeededTaskCount = protocolObject.NumSucceededTasks;
            this.taskRetryCount = protocolObject.NumTaskRetries;
            this.url = protocolObject.Url;
            this.userCpuTime = protocolObject.UserCPUTime;
            this.waitTime = protocolObject.WaitTime;
            this.wallClockTime = protocolObject.WallClockTime;
            this.writeIOGiB = protocolObject.WriteIOGiB;
            this.writeIOps = protocolObject.WriteIOps;
        }

        #endregion Constructors

        #region JobScheduleStatistics

        /// <summary>
        /// Gets the total number of tasks in the job that failed during the given time range.
        /// </summary>
        public long FailedTaskCount
        {
            get { return this.failedTaskCount; }
        }

        /// <summary>
        /// Gets the total kernel mode CPU time (per core) consumed by all tasks in the job schedule.
        /// </summary>
        public TimeSpan KernelCpuTime
        {
            get { return this.kernelCpuTime; }
        }

        /// <summary>
        /// Gets the time at which the statistics were last updated. All statistics are limited to the range between <see 
        /// cref="StartTime"/> and this value.
        /// </summary>
        public DateTime LastUpdateTime
        {
            get { return this.lastUpdateTime; }
        }

        /// <summary>
        /// Gets the total gibibytes of I/O read from disk by all tasks in the job schedule.
        /// </summary>
        public double ReadIOGiB
        {
            get { return this.readIOGiB; }
        }

        /// <summary>
        /// Gets the total number of disk read operations made by all tasks in the job schedule.
        /// </summary>
        public long ReadIOps
        {
            get { return this.readIOps; }
        }

        /// <summary>
        /// Gets the start time of the time range covered by the statistics.
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime; }
        }

        /// <summary>
        /// Gets the total number of tasks successfully completed in the job schedule.
        /// </summary>
        public long SucceededTaskCount
        {
            get { return this.succeededTaskCount; }
        }

        /// <summary>
        /// Gets the total number of retries that occurred on all tasks in the job schedule.
        /// </summary>
        public long TaskRetryCount
        {
            get { return this.taskRetryCount; }
        }

        /// <summary>
        /// Gets the URL of the statistics.
        /// </summary>
        public string Url
        {
            get { return this.url; }
        }

        /// <summary>
        /// Gets the total user mode CPU time (per core) consumed by all tasks in the job schedule.
        /// </summary>
        public TimeSpan UserCpuTime
        {
            get { return this.userCpuTime; }
        }

        /// <summary>
        /// Gets the total wait time of all tasks in jobs created under the schedule. The wait time for a task is defined 
        /// as the elapsed time between the creation of the task and the start of task execution. (If the task is retried 
        /// due to failures, the wait time is the time to the most recent task execution.)
        /// </summary>
        /// <remarks>
        /// This value is only reported in the account lifetime statistics.
        /// </remarks>
        public TimeSpan WaitTime
        {
            get { return this.waitTime; }
        }

        /// <summary>
        /// Gets the total wall clock time of all tasks in the job schedule. Note that if any task was retried multiple times, 
        /// this includes the wall clock time of all the task retries.
        /// </summary>
        public TimeSpan WallClockTime
        {
            get { return this.wallClockTime; }
        }

        /// <summary>
        /// Gets the total gibibytes of I/O written to disk by all tasks in the job schedule.
        /// </summary>
        public double WriteIOGiB
        {
            get { return this.writeIOGiB; }
        }

        /// <summary>
        /// Gets the total number of disk write operations made by all tasks in the job schedule.
        /// </summary>
        public long WriteIOps
        {
            get { return this.writeIOps; }
        }

        #endregion // JobScheduleStatistics

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}