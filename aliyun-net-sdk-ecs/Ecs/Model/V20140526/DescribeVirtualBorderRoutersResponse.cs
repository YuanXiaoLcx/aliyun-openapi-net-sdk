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
	public class DescribeVirtualBorderRoutersResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeVirtualBorderRouters_VirtualBorderRouterType> virtualBorderRouterSet;

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

		public List<DescribeVirtualBorderRouters_VirtualBorderRouterType> VirtualBorderRouterSet
		{
			get
			{
				return virtualBorderRouterSet;
			}
			set	
			{
				virtualBorderRouterSet = value;
			}
		}

		public class DescribeVirtualBorderRouters_VirtualBorderRouterType
		{

			private string vbrId;

			private string creationTime;

			private string activationTime;

			private string terminationTime;

			private string recoveryTime;

			private string status;

			private int? vlanId;

			private string circuitCode;

			private string routeTableId;

			private string vlanInterfaceId;

			private string localGatewayIp;

			private string peerGatewayIp;

			private string peeringSubnetMask;

			private string physicalConnectionId;

			private string physicalConnectionStatus;

			private string physicalConnectionBusinessStatus;

			private string physicalConnectionOwnerUid;

			private string accessPointId;

			private string name;

			private string description;

			public string VbrId
			{
				get
				{
					return vbrId;
				}
				set	
				{
					vbrId = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string ActivationTime
			{
				get
				{
					return activationTime;
				}
				set	
				{
					activationTime = value;
				}
			}

			public string TerminationTime
			{
				get
				{
					return terminationTime;
				}
				set	
				{
					terminationTime = value;
				}
			}

			public string RecoveryTime
			{
				get
				{
					return recoveryTime;
				}
				set	
				{
					recoveryTime = value;
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

			public int? VlanId
			{
				get
				{
					return vlanId;
				}
				set	
				{
					vlanId = value;
				}
			}

			public string CircuitCode
			{
				get
				{
					return circuitCode;
				}
				set	
				{
					circuitCode = value;
				}
			}

			public string RouteTableId
			{
				get
				{
					return routeTableId;
				}
				set	
				{
					routeTableId = value;
				}
			}

			public string VlanInterfaceId
			{
				get
				{
					return vlanInterfaceId;
				}
				set	
				{
					vlanInterfaceId = value;
				}
			}

			public string LocalGatewayIp
			{
				get
				{
					return localGatewayIp;
				}
				set	
				{
					localGatewayIp = value;
				}
			}

			public string PeerGatewayIp
			{
				get
				{
					return peerGatewayIp;
				}
				set	
				{
					peerGatewayIp = value;
				}
			}

			public string PeeringSubnetMask
			{
				get
				{
					return peeringSubnetMask;
				}
				set	
				{
					peeringSubnetMask = value;
				}
			}

			public string PhysicalConnectionId
			{
				get
				{
					return physicalConnectionId;
				}
				set	
				{
					physicalConnectionId = value;
				}
			}

			public string PhysicalConnectionStatus
			{
				get
				{
					return physicalConnectionStatus;
				}
				set	
				{
					physicalConnectionStatus = value;
				}
			}

			public string PhysicalConnectionBusinessStatus
			{
				get
				{
					return physicalConnectionBusinessStatus;
				}
				set	
				{
					physicalConnectionBusinessStatus = value;
				}
			}

			public string PhysicalConnectionOwnerUid
			{
				get
				{
					return physicalConnectionOwnerUid;
				}
				set	
				{
					physicalConnectionOwnerUid = value;
				}
			}

			public string AccessPointId
			{
				get
				{
					return accessPointId;
				}
				set	
				{
					accessPointId = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}
		}
	}
}
