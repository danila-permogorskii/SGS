﻿using Entities;
 using Newtonsoft.Json;

 namespace ParceData
{
    public class Valute : AuditableEntity
    {
        [JsonProperty("ID")]
        public string ValuteId { get; set; }
        public string Name { get; set; } 
        public int Nominal { get; set; } 
        public double Previous { get; set; }
        public double Value { get; set; } 
        public string CharCode { get; set; }
        public string NumCode { get; set; } 

        public Valute(string valuteId, string numCode, string charCode, int nominal, string name, double value, double previous)
        {
            ValuteId = valuteId;
            Name = name;
            Nominal = nominal;
            Previous = previous;
            Value = value;
            CharCode = charCode;
            NumCode = numCode;
        }
    }
}