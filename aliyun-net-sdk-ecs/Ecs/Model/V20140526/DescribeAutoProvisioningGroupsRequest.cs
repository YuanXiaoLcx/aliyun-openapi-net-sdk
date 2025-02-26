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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribeAutoProvisioningGroupsRequest : RpcAcsRequest<DescribeAutoProvisioningGroupsResponse>
    {
        public DescribeAutoProvisioningGroupsRequest()
            : base("Ecs", "2014-05-26", "DescribeAutoProvisioningGroups", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private int? pageNumber;

		private int? pageSize;

		private List<string> autoProvisioningGroupStatuss;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private List<string> autoProvisioningGroupIds;

		private string autoProvisioningGroupName;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public List<string> AutoProvisioningGroupStatuss
		{
			get
			{
				return autoProvisioningGroupStatuss;
			}

			set
			{
				autoProvisioningGroupStatuss = value;
				for (int i = 0; i < autoProvisioningGroupStatuss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AutoProvisioningGroupStatus." + (i + 1) , autoProvisioningGroupStatuss[i]);
				}
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public List<string> AutoProvisioningGroupIds
		{
			get
			{
				return autoProvisioningGroupIds;
			}

			set
			{
				autoProvisioningGroupIds = value;
				for (int i = 0; i < autoProvisioningGroupIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AutoProvisioningGroupId." + (i + 1) , autoProvisioningGroupIds[i]);
				}
			}
		}

		public string AutoProvisioningGroupName
		{
			get
			{
				return autoProvisioningGroupName;
			}
			set	
			{
				autoProvisioningGroupName = value;
				DictionaryUtil.Add(QueryParameters, "AutoProvisioningGroupName", value);
			}
		}

        public override DescribeAutoProvisioningGroupsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeAutoProvisioningGroupsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
