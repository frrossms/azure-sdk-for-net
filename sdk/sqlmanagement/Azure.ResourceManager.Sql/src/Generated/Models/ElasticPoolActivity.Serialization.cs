// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ElasticPoolActivity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ElasticPoolActivity DeserializeElasticPoolActivity(JsonElement element)
        {
            Optional<string> location = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<int> errorCode = default;
            Optional<string> errorMessage = default;
            Optional<int> errorSeverity = default;
            Optional<string> operation = default;
            Optional<Guid> operationId = default;
            Optional<int> percentComplete = default;
            Optional<int> requestedDatabaseDtuMax = default;
            Optional<int> requestedDatabaseDtuMin = default;
            Optional<int> requestedDtu = default;
            Optional<string> requestedElasticPoolName = default;
            Optional<long> requestedStorageLimitInGB = default;
            Optional<string> elasticPoolName = default;
            Optional<string> serverName = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> state = default;
            Optional<int> requestedStorageLimitInMB = default;
            Optional<int> requestedDatabaseDtuGuarantee = default;
            Optional<int> requestedDatabaseDtuCap = default;
            Optional<int> requestedDtuGuarantee = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("endTime"))
                        {
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("errorCode"))
                        {
                            errorCode = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("errorMessage"))
                        {
                            errorMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("errorSeverity"))
                        {
                            errorSeverity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("operation"))
                        {
                            operation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operationId"))
                        {
                            operationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("percentComplete"))
                        {
                            percentComplete = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedDatabaseDtuMax"))
                        {
                            requestedDatabaseDtuMax = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedDatabaseDtuMin"))
                        {
                            requestedDatabaseDtuMin = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedDtu"))
                        {
                            requestedDtu = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedElasticPoolName"))
                        {
                            requestedElasticPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requestedStorageLimitInGB"))
                        {
                            requestedStorageLimitInGB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("elasticPoolName"))
                        {
                            elasticPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverName"))
                        {
                            serverName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"))
                        {
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requestedStorageLimitInMB"))
                        {
                            requestedStorageLimitInMB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedDatabaseDtuGuarantee"))
                        {
                            requestedDatabaseDtuGuarantee = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedDatabaseDtuCap"))
                        {
                            requestedDatabaseDtuCap = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedDtuGuarantee"))
                        {
                            requestedDtuGuarantee = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ElasticPoolActivity(id.Value, name.Value, type.Value, location.Value, Optional.ToNullable(endTime), Optional.ToNullable(errorCode), errorMessage.Value, Optional.ToNullable(errorSeverity), operation.Value, Optional.ToNullable(operationId), Optional.ToNullable(percentComplete), Optional.ToNullable(requestedDatabaseDtuMax), Optional.ToNullable(requestedDatabaseDtuMin), Optional.ToNullable(requestedDtu), requestedElasticPoolName.Value, Optional.ToNullable(requestedStorageLimitInGB), elasticPoolName.Value, serverName.Value, Optional.ToNullable(startTime), state.Value, Optional.ToNullable(requestedStorageLimitInMB), Optional.ToNullable(requestedDatabaseDtuGuarantee), Optional.ToNullable(requestedDatabaseDtuCap), Optional.ToNullable(requestedDtuGuarantee));
        }
    }
}