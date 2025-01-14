﻿/*
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

using System;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Profile;

namespace Aliyun.Acs.Feature.Test
{
    public class FeatureTestBase
    {
        private static FeatureTestBase featureTestClient { get; set; }
        private static FeatureTestBase FeatureTestClient()
        {
            if (null == featureTestClient)
            {
                featureTestClient = new FeatureTestBase();
            }
            return featureTestClient;
        }

        internal string AccessKeyId = "ACCESS_KEY_ID";
        internal string AccessKeySecret = "ACCESS_KEY_SECRET";
        internal string roleArn = "RAM";
        internal string bearerToken = "BEARERTOKEN";
        internal string regionId = "cn-shanghai";

        public FeatureTestBase()
        {
            AccessKeyId = Environment.GetEnvironmentVariable("ACCESS_KEY_ID") ?? "FakeAccessKeyId";
            AccessKeySecret = Environment.GetEnvironmentVariable("ACCESS_KEY_SECRET") ?? "FakeAccessKeySecret";
            roleArn = Environment.GetEnvironmentVariable("RAM") ?? "FakeRoleArn";
            bearerToken = Environment.GetEnvironmentVariable("BEARERTOKEN") ?? "FakeBearerToken";
        }

        public DefaultAcsClient client;

        public IClientProfile profile;

        public DefaultAcsClient GetDefaultClient()
        {
            DefaultProfile.ClearProfile();
            profile = DefaultProfile.GetProfile(regionId, GetBasicAccessKeyId(), GetBasicAccessKeySecret());
            client = new DefaultAcsClient(profile);
            client.SetConnectTimeoutInMilliSeconds(2 * 60 * 1000);
            client.SetReadTimeoutInMilliSeconds(2 * 60 * 1000);
            return client;
        }

        public static string GetBasicAccessKeyId()
        {
            return FeatureTestClient().AccessKeyId;
        }

        public static string GetBasicAccessKeySecret()
        {
            return FeatureTestClient().AccessKeySecret;
        }

        public static string GetRoleArn()
        {
            return FeatureTestClient().roleArn;
        }

        public static string GetBearerToken()
        {
            return FeatureTestClient().bearerToken;
        }

        public string GetToken()
        {
            var assumeRoleRequest = new AssumeRoleRequest();
            assumeRoleRequest.RoleArn = GetRoleArn();
            assumeRoleRequest.RoleSessionName = "robert_test";

            var assumeRoleResponse = GetDefaultClient().GetAcsResponse(assumeRoleRequest);

            return assumeRoleResponse.Credentials.SecurityToken;
        }
    }
}
