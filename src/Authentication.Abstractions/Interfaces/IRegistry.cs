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
    /// <summary>
    /// Registry for components used by powershell cmdlets
    /// </summary>
    public interface IRegistry
    {
        /// <summary>
        /// Try to get the shared component registered in this session with the given type and name
        /// </summary>
        /// <typeparam name="T">The type of the custom component</typeparam>
        /// <param name="componentName">The name of the custom component</param>
        /// <param name="component">If the component is found, the registered component, otherwise null</param>
        /// <returns>True if the component is found, False otherwise</returns>
        bool TryGetComponent<T>(string componentName, out T component) where T : class;

        /// <summary>
        /// Register the given shared component in this session, if it is not already registered
        /// </summary>
        /// <typeparam name="T">The type of the shared component</typeparam>
        /// <param name="componentName">The name of the shared component</param>
        /// <param name="componentInitializer"></param>
        void RegisterComponent<T>(string componentName, Func<T> componentInitializer) where T : class;

        /// <summary>
        /// Register the given shared componente
        /// </summary>
        /// <typeparam name="T">The type of the shared component</typeparam>
        /// <param name="componentName">The name of the shared component</param>
        /// <param name="componentInitializer">The initializer for the component</param>
        /// <param name="overwrite">Whether to overwrite an existing component with the new one</param>
        void RegisterComponent<T>(string componentName, Func<T> componentInitializer, bool overwrite) where T : class;

        /// <summary>
        /// Remove the provided component from the shared components registry
        /// </summary>
        /// <typeparam name="T">The type of the component</typeparam>
        /// <param name="componentName">The component name</param>
        void UnregisterComponent<T>(string componentName) where T : class;

        /// <summary>
        /// Remove all components from the session shared component registry
        /// </summary>
        void ClearComponents();

    }
}
