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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class DescribeUpPeakPublishStreamDataRequest : RpcAcsRequest<DescribeUpPeakPublishStreamDataResponse>
    {
        public DescribeUpPeakPublishStreamDataRequest()
            : base("live", "2016-11-01", "DescribeUpPeakPublishStreamData", "live", "openAPI")
        {
        }

		private string domainName;

		private string endTime;

		private string startTime;

		private long? ownerId;

		private string domainSwitch;

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
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
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
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

		public string DomainSwitch
		{
			get
			{
				return domainSwitch;
			}
			set	
			{
				domainSwitch = value;
				DictionaryUtil.Add(QueryParameters, "DomainSwitch", value);
			}
		}

        public override DescribeUpPeakPublishStreamDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeUpPeakPublishStreamDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
