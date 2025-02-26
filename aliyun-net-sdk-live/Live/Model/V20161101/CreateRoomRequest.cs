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
    public class CreateRoomRequest : RpcAcsRequest<CreateRoomResponse>
    {
        public CreateRoomRequest()
            : base("live", "2016-11-01", "CreateRoom", "live", "openAPI")
        {
        }

		private string templateIds;

		private string anchorId;

		private bool? useAppTranscode;

		private long? ownerId;

		private string roomId;

		private string appId;

		public string TemplateIds
		{
			get
			{
				return templateIds;
			}
			set	
			{
				templateIds = value;
				DictionaryUtil.Add(QueryParameters, "TemplateIds", value);
			}
		}

		public string AnchorId
		{
			get
			{
				return anchorId;
			}
			set	
			{
				anchorId = value;
				DictionaryUtil.Add(QueryParameters, "AnchorId", value);
			}
		}

		public bool? UseAppTranscode
		{
			get
			{
				return useAppTranscode;
			}
			set	
			{
				useAppTranscode = value;
				DictionaryUtil.Add(QueryParameters, "UseAppTranscode", value.ToString());
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

		public string RoomId
		{
			get
			{
				return roomId;
			}
			set	
			{
				roomId = value;
				DictionaryUtil.Add(QueryParameters, "RoomId", value);
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

        public override CreateRoomResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateRoomResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
