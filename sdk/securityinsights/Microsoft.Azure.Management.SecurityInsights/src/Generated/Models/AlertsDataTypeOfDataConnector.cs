// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Alerts data type for data connectors.
    /// </summary>
    public partial class AlertsDataTypeOfDataConnector
    {
        /// <summary>
        /// Initializes a new instance of the AlertsDataTypeOfDataConnector
        /// class.
        /// </summary>
        public AlertsDataTypeOfDataConnector()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertsDataTypeOfDataConnector
        /// class.
        /// </summary>
        /// <param name="alerts">Alerts data type connection.</param>
        public AlertsDataTypeOfDataConnector(DataConnectorDataTypeCommon alerts = default(DataConnectorDataTypeCommon))
        {
            Alerts = alerts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets alerts data type connection.
        /// </summary>
        [JsonProperty(PropertyName = "alerts")]
        public DataConnectorDataTypeCommon Alerts { get; set; }

    }
}
