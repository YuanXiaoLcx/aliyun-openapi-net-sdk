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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class GetSetResponse : AcsResponse
	{

		private string requestId;

		private string setId;

		private string setName;

		private string createTime;

		private string modifyTime;

		private int? faceCount;

		private int? imageCount;

		private int? videoCount;

		private int? videoLength;

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

		public string SetId
		{
			get
			{
				return setId;
			}
			set	
			{
				setId = value;
			}
		}

		public string SetName
		{
			get
			{
				return setName;
			}
			set	
			{
				setName = value;
			}
		}

		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public string ModifyTime
		{
			get
			{
				return modifyTime;
			}
			set	
			{
				modifyTime = value;
			}
		}

		public int? FaceCount
		{
			get
			{
				return faceCount;
			}
			set	
			{
				faceCount = value;
			}
		}

		public int? ImageCount
		{
			get
			{
				return imageCount;
			}
			set	
			{
				imageCount = value;
			}
		}

		public int? VideoCount
		{
			get
			{
				return videoCount;
			}
			set	
			{
				videoCount = value;
			}
		}

		public int? VideoLength
		{
			get
			{
				return videoLength;
			}
			set	
			{
				videoLength = value;
			}
		}
	}
}
