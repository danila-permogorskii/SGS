﻿using System;
 using Newtonsoft.Json;

 namespace Entities
{
    public abstract class Entity
    {
        [JsonIgnore]
        public int ID { get; set; }
    }
}