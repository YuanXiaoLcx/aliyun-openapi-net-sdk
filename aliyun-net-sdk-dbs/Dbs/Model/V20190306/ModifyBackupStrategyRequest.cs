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
using Aliyun.Acs.Dbs.Transform;
using Aliyun.Acs.Dbs.Transform.V20190306;

namespace Aliyun.Acs.Dbs.Model.V20190306
{
    public class ModifyBackupStrategyRequest : RpcAcsRequest<ModifyBackupStrategyResponse>
    {
        public ModifyBackupStrategyRequest()
            : base("Dbs", "2019-03-06", "ModifyBackupStrategy", "cbs", "openAPI")
        {
        }

		private string backupPeriod;

		private string backupStartTime;

		private string clientToken;

		private string backupPlanId;

		private string ownerId;

		public string BackupPeriod
		{
			get
			{
				return backupPeriod;
			}
			set	
			{
				backupPeriod = value;
				DictionaryUtil.Add(QueryParameters, "BackupPeriod", value);
			}
		}

		public string BackupStartTime
		{
			get
			{
				return backupStartTime;
			}
			set	
			{
				backupStartTime = value;
				DictionaryUtil.Add(QueryParameters, "BackupStartTime", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string BackupPlanId
		{
			get
			{
				return backupPlanId;
			}
			set	
			{
				backupPlanId = value;
				DictionaryUtil.Add(QueryParameters, "BackupPlanId", value);
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

        public override ModifyBackupStrategyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyBackupStrategyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
