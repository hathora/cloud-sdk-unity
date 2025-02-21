
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
    

    public class UpdateUserInviteScopesType
    {
        private UpdateUserInviteScopesType(string value) { Value = value; }

        public string Value { get; private set; }
        public static UpdateUserInviteScopesType UserRole { get { return new UpdateUserInviteScopesType("UserRole"); } }
        public static UpdateUserInviteScopesType ArrayOfScope { get { return new UpdateUserInviteScopesType("arrayOfScope"); } }
        public static UpdateUserInviteScopesType Null { get { return new UpdateUserInviteScopesType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(UpdateUserInviteScopesType v) { return v.Value; }
        public static UpdateUserInviteScopesType FromString(string v) {
            switch(v) {
                case "UserRole": return UserRole;
                case "arrayOfScope": return ArrayOfScope;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for UpdateUserInviteScopesType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((UpdateUserInviteScopesType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    
/// <summary>
/// Scopes can only be removed or added if a user has those scopes.
/// </summary>
    [JsonConverter(typeof(UpdateUserInviteScopes.UpdateUserInviteScopesConverter))]
    public class UpdateUserInviteScopes {
        public UpdateUserInviteScopes(UpdateUserInviteScopesType type) {
            Type = type;
        }
        public UserRole? UserRole { get; set; } 
        public List<Scope>? ArrayOfScope { get; set; } 

        public UpdateUserInviteScopesType Type {get; set; }


        public static UpdateUserInviteScopes CreateUserRole(UserRole userRole) {
            UpdateUserInviteScopesType typ = UpdateUserInviteScopesType.UserRole;

            UpdateUserInviteScopes res = new UpdateUserInviteScopes(typ);
            res.UserRole = userRole;
            return res;
        }

        public static UpdateUserInviteScopes CreateArrayOfScope(List<Scope> arrayOfScope) {
            UpdateUserInviteScopesType typ = UpdateUserInviteScopesType.ArrayOfScope;

            UpdateUserInviteScopes res = new UpdateUserInviteScopes(typ);
            res.ArrayOfScope = arrayOfScope;
            return res;
        }

        public static UpdateUserInviteScopes CreateNull() {
            UpdateUserInviteScopesType typ = UpdateUserInviteScopesType.Null;
            return new UpdateUserInviteScopes(typ);
        }

        public class UpdateUserInviteScopesConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(UpdateUserInviteScopes);

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
                    return new UpdateUserInviteScopes(UpdateUserInviteScopesType.UserRole) {
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
                    return new UpdateUserInviteScopes(UpdateUserInviteScopesType.ArrayOfScope) {
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
                UpdateUserInviteScopes res = (UpdateUserInviteScopes)value;
                if (UpdateUserInviteScopesType.FromString(res.Type).Equals(UpdateUserInviteScopesType.Null))
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