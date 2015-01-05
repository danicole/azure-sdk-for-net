// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;

namespace Microsoft.WindowsAzure.WebSitesExtensions.Models
{
    /// <summary>
    /// The continuous WebJob settings operation response.
    /// </summary>
    public partial class ContinuousWebJobSettingsResponse : AzureOperationResponse
    {
        private bool? _isSingleton;
        
        /// <summary>
        /// Optional. If a continuous job is set as singleton it'll run only on
        /// a single instance opposed to running on all instances.
        /// </summary>
        public bool? IsSingleton
        {
            get { return this._isSingleton; }
            set { this._isSingleton = value; }
        }
        
        private int? _shutdownGraceTimeInSeconds;
        
        /// <summary>
        /// Optional. Specify the time in seconds to wait for the WebJob to
        /// gracefully shutdown.
        /// </summary>
        public int? ShutdownGraceTimeInSeconds
        {
            get { return this._shutdownGraceTimeInSeconds; }
            set { this._shutdownGraceTimeInSeconds = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ContinuousWebJobSettingsResponse
        /// class.
        /// </summary>
        public ContinuousWebJobSettingsResponse()
        {
        }
    }
}
