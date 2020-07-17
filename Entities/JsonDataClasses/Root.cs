using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ParceData;

namespace Entities.JsonDataClasses
{
    public class Root
    {
        [JsonProperty("Date")]
        public DateTime Date { get; set; } 
        [JsonProperty("PreviousDate")]
        public DateTime PreviousDate { get; set; } 
        [JsonProperty("PreviousUrl")]
        public string PreviousUrl { get; set; } 
        [JsonProperty("Timestamp")]
        public DateTime Timestamp { get; set; } 
        [JsonProperty("Valute")]
        public Dictionary<string, Valute> Valute { get; set; }
    }
    
    
}