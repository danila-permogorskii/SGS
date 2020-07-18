﻿using System;
 using System.ComponentModel.DataAnnotations;
 using Newtonsoft.Json;

 namespace Entities
{
    public abstract class Entity
    {
        [JsonIgnore]
        [Key]
        public int ID { get; set; }
    }
}