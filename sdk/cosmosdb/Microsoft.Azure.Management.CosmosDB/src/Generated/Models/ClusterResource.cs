// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Representation of a managed Cassandra cluster.
    /// </summary>
    public partial class ClusterResource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the ClusterResource class.
        /// </summary>
        public ClusterResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterResource class.
        /// </summary>
        /// <param name="properties">Properties of a managed Cassandra
        /// cluster.</param>
        public ClusterResource(ClusterResourceProperties properties = default(ClusterResourceProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of a managed Cassandra cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ClusterResourceProperties Properties { get; set; }

    }
}
