/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeFleetHistoryResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeFleetHistory_FleetHistory> fleetHistorys;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeFleetHistory_FleetHistory> FleetHistorys
		{
			get
			{
				return fleetHistorys;
			}
			set	
			{
				fleetHistorys = value;
			}
		}

		public class DescribeFleetHistory_FleetHistory
		{

			private string taskId;

			private string status;

			private string lastEventTime;

			private string startTime;

			private List<DescribeFleetHistory_ActivityDetail> activityDetails;

			public string TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string LastEventTime
			{
				get
				{
					return lastEventTime;
				}
				set	
				{
					lastEventTime = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public List<DescribeFleetHistory_ActivityDetail> ActivityDetails
			{
				get
				{
					return activityDetails;
				}
				set	
				{
					activityDetails = value;
				}
			}

			public class DescribeFleetHistory_ActivityDetail
			{

				private string detail;

				private float? status;

				public string Detail
				{
					get
					{
						return detail;
					}
					set	
					{
						detail = value;
					}
				}

				public float? Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}
		}
	}
}
