
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
    using System.Collections.Generic;
    using System.Numerics;
    using System;
    using UnityEngine;
    

    public class PendingOrgInviteScopesType
    {
        private PendingOrgInviteScopesType(string value) { Value = value; }

        public string Value { get; private set; }
        public static PendingOrgInviteScopesType UserRole { get { return new PendingOrgInviteScopesType("UserRole"); } }
        public static PendingOrgInviteScopesType ArrayOfScope { get { return new PendingOrgInviteScopesType("arrayOfScope"); } }
        public static PendingOrgInviteScopesType Null { get { return new PendingOrgInviteScopesType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(PendingOrgInviteScopesType v) { return v.Value; }
        public static PendingOrgInviteScopesType FromString(string v) {
            switch(v) {
                case "UserRole": return UserRole;
                case "arrayOfScope": return ArrayOfScope;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for PendingOrgInviteScopesType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((PendingOrgInviteScopesType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(PendingOrgInviteScopes.PendingOrgInviteScopesConverter))]
    public class PendingOrgInviteScopes {
        public PendingOrgInviteScopes(PendingOrgInviteScopesType type) {
            Type = type;
        }
        public UserRole? UserRole { get; set; } 
        public List<Scope>? ArrayOfScope { get; set; } 

        public PendingOrgInviteScopesType Type {get; set; }


        public static PendingOrgInviteScopes CreateUserRole(UserRole userRole) {
            PendingOrgInviteScopesType typ = PendingOrgInviteScopesType.UserRole;

            PendingOrgInviteScopes res = new PendingOrgInviteScopes(typ);
            res.UserRole = userRole;
            return res;
        }

        public static PendingOrgInviteScopes CreateArrayOfScope(List<Scope> arrayOfScope) {
            PendingOrgInviteScopesType typ = PendingOrgInviteScopesType.ArrayOfScope;

            PendingOrgInviteScopes res = new PendingOrgInviteScopes(typ);
            res.ArrayOfScope = arrayOfScope;
            return res;
        }

        public static PendingOrgInviteScopes CreateNull() {
            PendingOrgInviteScopesType typ = PendingOrgInviteScopesType.Null;
            return new PendingOrgInviteScopes(typ);
        }

        public class PendingOrgInviteScopesConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(PendingOrgInviteScopes);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    UserRole? userRole = JsonConvert.DeserializeObject<UserRole>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonDeserializers(typeof(UserRole))});
                    return new PendingOrgInviteScopes(PendingOrgInviteScopesType.UserRole) {
                        UserRole = userRole
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
                    List<Scope>? arrayOfScope = JsonConvert.DeserializeObject<List<Scope>>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonDeserializers(typeof(List<Scope>))});
                    return new PendingOrgInviteScopes(PendingOrgInviteScopesType.ArrayOfScope) {
                        ArrayOfScope = arrayOfScope
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
                PendingOrgInviteScopes res = (PendingOrgInviteScopes)value;
                if (PendingOrgInviteScopesType.FromString(res.Type).Equals(PendingOrgInviteScopesType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.UserRole != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.UserRole));
                    return;
                }
                if (res.ArrayOfScope != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfScope));
                    return;
                }

            }
        }

    }

}