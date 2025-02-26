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

namespace Aliyun.Acs.ARMS.Model.V20190808
{
	public class SearchRetcodeAppByPageResponse : AcsResponse
	{

		private string requestId;

		private SearchRetcodeAppByPage_PageBean pageBean;

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

		public SearchRetcodeAppByPage_PageBean PageBean
		{
			get
			{
				return pageBean;
			}
			set	
			{
				pageBean = value;
			}
		}

		public class SearchRetcodeAppByPage_PageBean
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<SearchRetcodeAppByPage_RetcodeApp> retcodeApps;

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

			public List<SearchRetcodeAppByPage_RetcodeApp> RetcodeApps
			{
				get
				{
					return retcodeApps;
				}
				set	
				{
					retcodeApps = value;
				}
			}

			public class SearchRetcodeAppByPage_RetcodeApp
			{

				private long? appId;

				private string pid;

				private string appName;

				private string type;

				private string userId;

				private string regionId;

				private long? createTime;

				private long? updateTime;

				public long? AppId
				{
					get
					{
						return appId;
					}
					set	
					{
						appId = value;
					}
				}

				public string Pid
				{
					get
					{
						return pid;
					}
					set	
					{
						pid = value;
					}
				}

				public string AppName
				{
					get
					{
						return appName;
					}
					set	
					{
						appName = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}

				public long? CreateTime
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

				public long? UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}
			}
		}
	}
}
