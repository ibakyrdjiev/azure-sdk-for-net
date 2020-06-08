// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class ScriptAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("uri");
            writer.WriteStringValue(Uri);
            writer.WritePropertyName("roles");
            writer.WriteStringValue(Roles.ToString());
            if (Parameters != null)
            {
                writer.WritePropertyName("parameters");
                writer.WriteStringValue(Parameters);
            }
            writer.WriteEndObject();
        }

        internal static ScriptAction DeserializeScriptAction(JsonElement element)
        {
            string name = default;
            string uri = default;
            HdiNodeTypes roles = default;
            string parameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uri"))
                {
                    uri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roles"))
                {
                    roles = new HdiNodeTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = property.Value.GetString();
                    continue;
                }
            }
            return new ScriptAction(name, uri, roles, parameters);
        }
    }
}