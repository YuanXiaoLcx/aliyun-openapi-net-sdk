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
    public class BatchSetEdgeInstanceDeviceConfigRequest : RpcAcsRequest<BatchSetEdgeInstanceDeviceConfigResponse>
    {
        public BatchSetEdgeInstanceDeviceConfigRequest()
            : base("Iot", "2018-01-20", "BatchSetEdgeInstanceDeviceConfig", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string instanceId;

		private List<DeviceConfigs> deviceConfigss;

		private string iotInstanceId;

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public List<DeviceConfigs> DeviceConfigss
		{
			get
			{
				return deviceConfigss;
			}

			set
			{
				deviceConfigss = value;
				for (int i = 0; i < deviceConfigss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DeviceConfigs." + (i + 1) + ".IotId", deviceConfigss[i].IotId);
					DictionaryUtil.Add(QueryParameters,"DeviceConfigs." + (i + 1) + ".Content", deviceConfigss[i].Content);
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

		public class DeviceConfigs
		{

			private string iotId;

			private string content;

			public string IotId
			{
				get
				{
					return iotId;
				}
				set	
				{
					iotId = value;
				}
			}

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override BatchSetEdgeInstanceDeviceConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BatchSetEdgeInstanceDeviceConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
