// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.Commands.Common.Authentication.Abstractions
{
    public static class AzureSessionExtensions
    {
        public static IClientFactory GetClientFactory(this IAzureSession session, IAuthenticationFactory authenticator)
        {
            IClientFactory result = null;
            IClientFactoryProvider provider;
            if (session.TryGetComponent(session.ClientFactoryName, out provider))
            {
                result = provider.CreateClientFactory(authenticator);
            }

            return result;
        }

        public static IClientFactory GetClientFactory(this IAzureSession session)
        {
            return session.GetClientFactory(session.GetAuthenticationFactory());
        }


        public static IAuthenticationFactory GetAuthenticationFactory(this IAzureSession session)
        {
            IAuthenticationFactory result = null;
            session.TryGetComponent(session.AuthenticationFactoryName, out result);
            return result;
        }

    }
}
