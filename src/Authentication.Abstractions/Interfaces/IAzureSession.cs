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
using System.Diagnostics;
using System.IO;

namespace Microsoft.Azure.Commands.Common.Authentication.Abstractions
{
    /// <summary>
    /// Represents current Azure session.
    /// </summary>
    public interface IAzureSession : IExtensibleModel, IRegistry
    {
        /// <summary>
        /// Gets or sets Azure client factory.
        /// </summary>
        string ClientFactoryName { get; set; }

        /// <summary>
        /// Gets or sets Azure authentication factory.
        /// </summary>
        string AuthenticationFactoryName { get; set; }

        /// <summary>
        /// Name of the context provider in the registry
        /// </summary>
        string ProfileProviderName { get; set; }

        /// <summary>
        /// Gets or sets data persistence store.
        /// </summary>
        string DataStoreName { get; set; }

        /// <summary>
        /// The name of the telemtry provider in the registry
        /// </summary>
        string TelemetryProviderName { get; set; }

        /// <summary>
        /// The directory containing session information
        /// </summary>
        string SessionDirectory { get; set; }
        /// <summary>
        /// The scope of context persistece, for now "Process" or "CurrentUser"
        /// </summary>
        string ContextSaveMode { get; set; }

    }
}
