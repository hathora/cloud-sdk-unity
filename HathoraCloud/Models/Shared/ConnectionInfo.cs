
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace HathoraCloud.Models.Shared
{
    using HathoraCloud.Models.Shared;
    using HathoraCloud.Utils;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using System.Numerics;
    using System;
    using UnityEngine;
    

    public class ConnectionInfoType
    {
        private ConnectionInfoType(string value) { Value = value; }

        public string Value { get; private set; }
        public static ConnectionInfoType StartingConnectionInfo { get { return new ConnectionInfoType("StartingConnectionInfo"); } }
        public static ConnectionInfoType ActiveConnectionInfo { get { return new ConnectionInfoType("ActiveConnectionInfo"); } }
        public static ConnectionInfoType Null { get { return new ConnectionInfoType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(ConnectionInfoType v) { return v.Value; }
        public static ConnectionInfoType FromString(string v) {
            switch(v) {
                case "StartingConnectionInfo": return StartingConnectionInfo;
                case "ActiveConnectionInfo": return ActiveConnectionInfo;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for ConnectionInfoType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((ConnectionInfoType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    
/// <summary>
/// Connection information to the default port.
/// </summary>
    [JsonConverter(typeof(ConnectionInfo.ConnectionInfoConverter))]
    public class ConnectionInfo {
        public ConnectionInfo(ConnectionInfoType type) {
            Type = type;
        }
        public StartingConnectionInfo? StartingConnectionInfo { get; set; } 
        public ActiveConnectionInfo? ActiveConnectionInfo { get; set; } 

        public ConnectionInfoType Type {get; set; }


        public static ConnectionInfo CreateStartingConnectionInfo(StartingConnectionInfo startingConnectionInfo) {
            ConnectionInfoType typ = ConnectionInfoType.StartingConnectionInfo;

            ConnectionInfo res = new ConnectionInfo(typ);
            res.StartingConnectionInfo = startingConnectionInfo;
            return res;
        }

        public static ConnectionInfo CreateActiveConnectionInfo(ActiveConnectionInfo activeConnectionInfo) {
            ConnectionInfoType typ = ConnectionInfoType.ActiveConnectionInfo;

            ConnectionInfo res = new ConnectionInfo(typ);
            res.ActiveConnectionInfo = activeConnectionInfo;
            return res;
        }

        public static ConnectionInfo CreateNull() {
            ConnectionInfoType typ = ConnectionInfoType.Null;
            return new ConnectionInfo(typ);
        }

        public class ConnectionInfoConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(ConnectionInfo);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    StartingConnectionInfo? startingConnectionInfo = JsonConvert.DeserializeObject<StartingConnectionInfo>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonDeserializers(typeof(StartingConnectionInfo))});
                    return new ConnectionInfo(ConnectionInfoType.StartingConnectionInfo) {
                        StartingConnectionInfo = startingConnectionInfo
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    ActiveConnectionInfo? activeConnectionInfo = JsonConvert.DeserializeObject<ActiveConnectionInfo>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonDeserializers(typeof(ActiveConnectionInfo))});
                    return new ConnectionInfo(ConnectionInfoType.ActiveConnectionInfo) {
                        ActiveConnectionInfo = activeConnectionInfo
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                ConnectionInfo res = (ConnectionInfo)value;
                if (ConnectionInfoType.FromString(res.Type).Equals(ConnectionInfoType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.StartingConnectionInfo != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.StartingConnectionInfo));
                    return;
                }
                if (res.ActiveConnectionInfo != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ActiveConnectionInfo));
                    return;
                }

            }
        }

    }

}