// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Attestation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters for patching an attestation service instance
    /// </summary>
    public partial class AttestationServicePatchParams : IResource
    {
        /// <summary>
        /// Initializes a new instance of the AttestationServicePatchParams
        /// class.
        /// </summary>
        public AttestationServicePatchParams()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AttestationServicePatchParams
        /// class.
        /// </summary>
        /// <param name="tags">The tags that will be assigned to the
        /// attestation service instance.</param>
        public AttestationServicePatchParams(IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tags that will be assigned to the attestation
        /// service instance.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
