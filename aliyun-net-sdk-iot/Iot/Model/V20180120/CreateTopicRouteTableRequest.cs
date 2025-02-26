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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class CreateTopicRouteTableRequest : RpcAcsRequest<CreateTopicRouteTableResponse>
    {
        public CreateTopicRouteTableRequest()
            : base("Iot", "2018-01-20", "CreateTopicRouteTable", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private List<string> dstTopics;

		private string iotInstanceId;

		private string srcTopic;

		public List<string> DstTopics
		{
			get
			{
				return dstTopics;
			}

			set
			{
				dstTopics = value;
				for (int i = 0; i < dstTopics.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DstTopic." + (i + 1) , dstTopics[i]);
				}
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public string SrcTopic
		{
			get
			{
				return srcTopic;
			}
			set	
			{
				srcTopic = value;
				DictionaryUtil.Add(QueryParameters, "SrcTopic", value);
			}
		}

        public override CreateTopicRouteTableResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTopicRouteTableResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
