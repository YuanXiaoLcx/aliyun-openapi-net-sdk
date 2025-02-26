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
using Aliyun.Acs.ARMS.Transform;
using Aliyun.Acs.ARMS.Transform.V20190808;

namespace Aliyun.Acs.ARMS.Model.V20190808
{
    public class ImportAppAlertRulesRequest : RpcAcsRequest<ImportAppAlertRulesResponse>
    {
        public ImportAppAlertRulesRequest()
            : base("ARMS", "2019-08-08", "ImportAppAlertRules", "arms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private bool? isAutoStart;

		private string contactGroupIds;

		private string pids;

		private string templateAlertId;

		public bool? IsAutoStart
		{
			get
			{
				return isAutoStart;
			}
			set	
			{
				isAutoStart = value;
				DictionaryUtil.Add(QueryParameters, "IsAutoStart", value.ToString());
			}
		}

		public string ContactGroupIds
		{
			get
			{
				return contactGroupIds;
			}
			set	
			{
				contactGroupIds = value;
				DictionaryUtil.Add(QueryParameters, "ContactGroupIds", value);
			}
		}

		public string Pids
		{
			get
			{
				return pids;
			}
			set	
			{
				pids = value;
				DictionaryUtil.Add(QueryParameters, "Pids", value);
			}
		}

		public string TemplateAlertId
		{
			get
			{
				return templateAlertId;
			}
			set	
			{
				templateAlertId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateAlertId", value);
			}
		}

        public override ImportAppAlertRulesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImportAppAlertRulesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
