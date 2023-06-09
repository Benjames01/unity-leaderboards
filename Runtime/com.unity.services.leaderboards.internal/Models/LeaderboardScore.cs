//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Leaderboards.Internal.Http;



namespace Unity.Services.Leaderboards.Internal.Models
{
    /// <summary>
    /// LeaderboardScore model
    /// </summary>
    [Preserve]
    [DataContract(Name = "LeaderboardScore")]
    internal class LeaderboardScore
    {
        /// <summary>
        /// Creates an instance of LeaderboardScore.
        /// </summary>
        /// <param name="score">score param</param>
        [Preserve]
        public LeaderboardScore(double score)
        {
            Score = score;
        }

        /// <summary>
        /// Parameter score of LeaderboardScore
        /// </summary>
        [Preserve]
        [DataMember(Name = "score", IsRequired = true, EmitDefaultValue = true)]
        public double Score{ get; }
    
        /// <summary>
        /// Formats a LeaderboardScore into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "score," + Score.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a LeaderboardScore as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var scoreStringValue = Score.ToString();
            dictionary.Add("score", scoreStringValue);
            
            return dictionary;
        }
    }
}
