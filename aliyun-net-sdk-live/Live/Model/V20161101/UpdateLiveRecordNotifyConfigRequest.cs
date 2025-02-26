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
    public class UpdateLiveRecordNotifyConfigRequest : RpcAcsRequest<UpdateLiveRecordNotifyConfigResponse>
    {
        public UpdateLiveRecordNotifyConfigRequest()
            : base("live", "2016-11-01", "UpdateLiveRecordNotifyConfig", "live", "openAPI")
        {
        }

		private string onDemandUrl;

		private string securityToken;

		private string domainName;

		private string notifyUrl;

		private long? ownerId;

		private bool? needStatusNotify;

		public string OnDemandUrl
		{
			get
			{
				return onDemandUrl;
			}
			set	
			{
				onDemandUrl = value;
				DictionaryUtil.Add(QueryParameters, "OnDemandUrl", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

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

		public string NotifyUrl
		{
			get
			{
				return notifyUrl;
			}
			set	
			{
				notifyUrl = value;
				DictionaryUtil.Add(QueryParameters, "NotifyUrl", value);
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

		public bool? NeedStatusNotify
		{
			get
			{
				return needStatusNotify;
			}
			set	
			{
				needStatusNotify = value;
				DictionaryUtil.Add(QueryParameters, "NeedStatusNotify", value.ToString());
			}
		}

        public override UpdateLiveRecordNotifyConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateLiveRecordNotifyConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
