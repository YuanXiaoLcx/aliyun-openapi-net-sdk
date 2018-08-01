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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class GetPhotoProcessTaskResponseUnmarshaller
    {
        public static GetPhotoProcessTaskResponse Unmarshall(UnmarshallerContext context)
        {
			GetPhotoProcessTaskResponse getPhotoProcessTaskResponse = new GetPhotoProcessTaskResponse();

			getPhotoProcessTaskResponse.HttpResponse = context.HttpResponse;
			getPhotoProcessTaskResponse.RequestId = context.StringValue("GetPhotoProcessTask.RequestId");
			getPhotoProcessTaskResponse.TaskId = context.StringValue("GetPhotoProcessTask.TaskId");
			getPhotoProcessTaskResponse.Status = context.StringValue("GetPhotoProcessTask.Status");
			getPhotoProcessTaskResponse.SrcUri = context.StringValue("GetPhotoProcessTask.SrcUri");
			getPhotoProcessTaskResponse.TgtUri = context.StringValue("GetPhotoProcessTask.TgtUri");
			getPhotoProcessTaskResponse.Style = context.StringValue("GetPhotoProcessTask.Style");
			getPhotoProcessTaskResponse.NotifyTopicName = context.StringValue("GetPhotoProcessTask.NotifyTopicName");
			getPhotoProcessTaskResponse.NotifyEndpoint = context.StringValue("GetPhotoProcessTask.NotifyEndpoint");
			getPhotoProcessTaskResponse.ExternalID = context.StringValue("GetPhotoProcessTask.ExternalID");
			getPhotoProcessTaskResponse.CreateTime = context.StringValue("GetPhotoProcessTask.CreateTime");
			getPhotoProcessTaskResponse.FinishTime = context.StringValue("GetPhotoProcessTask.FinishTime");
			getPhotoProcessTaskResponse.Percent = context.IntegerValue("GetPhotoProcessTask.Percent");
        
			return getPhotoProcessTaskResponse;
        }
    }
}