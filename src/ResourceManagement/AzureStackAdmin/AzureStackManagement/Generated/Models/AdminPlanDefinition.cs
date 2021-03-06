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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management.Models
{
    /// <summary>
    /// Your documentation here.
    /// </summary>
    public partial class AdminPlanDefinition
    {
        private string _description;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _displayName;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private string _externalReferenceId;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string ExternalReferenceId
        {
            get { return this._externalReferenceId; }
            set { this._externalReferenceId = value; }
        }
        
        private int? _maxOccurrencesPerOffer;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public int? MaxOccurrencesPerOffer
        {
            get { return this._maxOccurrencesPerOffer; }
            set { this._maxOccurrencesPerOffer = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private QuotaSyncState _quotaSyncState;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public QuotaSyncState QuotaSyncState
        {
            get { return this._quotaSyncState; }
            set { this._quotaSyncState = value; }
        }
        
        private IList<ServiceQuotaDefinition> _serviceQuotas;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public IList<ServiceQuotaDefinition> ServiceQuotas
        {
            get { return this._serviceQuotas; }
            set { this._serviceQuotas = value; }
        }
        
        private AccessibilityState _state;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public AccessibilityState State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private int? _subscriptionCount;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public int? SubscriptionCount
        {
            get { return this._subscriptionCount; }
            set { this._subscriptionCount = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AdminPlanDefinition class.
        /// </summary>
        public AdminPlanDefinition()
        {
            this.ServiceQuotas = new LazyList<ServiceQuotaDefinition>();
        }
    }
}
