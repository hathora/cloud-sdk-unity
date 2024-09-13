
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
    using Newtonsoft.Json;
    using System;
    using UnityEngine;
    
    public enum CardBrand
    {
        [JsonProperty("amex")]
        Amex,
        [JsonProperty("cartes_bancaires")]
        CartesBancaires,
        [JsonProperty("diners")]
        Diners,
        [JsonProperty("discover")]
        Discover,
        [JsonProperty("jcb")]
        Jcb,
        [JsonProperty("mastercard")]
        Mastercard,
        [JsonProperty("visa")]
        Visa,
        [JsonProperty("unionpay")]
        Unionpay,
        [JsonProperty("card")]
        Card,
    }

    public static class CardBrandExtension
    {
        public static string Value(this CardBrand value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static CardBrand ToEnum(this string value)
        {
            foreach(var field in typeof(CardBrand).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (CardBrand)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum CardBrand");
        }
    }

}