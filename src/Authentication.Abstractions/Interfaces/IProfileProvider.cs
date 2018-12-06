﻿// ----------------------------------------------------------------------------------
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

#if NETSTANDARD
using Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core;
#endif

namespace Microsoft.Azure.Commands.Common.Authentication.Abstractions
{
    public interface IProfileProvider
    {
        IAzureContextContainer Profile { get; set; }
        T GetProfile<T>() where T : class, IAzureContextContainer;
        void SetTokenCacheForProfile(IAzureContextContainer profile);
        void ResetDefaultProfile();

        /// <summary>
        /// Gets or sets token cache file path.
        /// </summary>
        string TokenCachePath { get; set; }

        /// <summary>
        /// Gets or sets profile directory.
        /// </summary>
        string ProfilePath { get; set; }

    }
}
