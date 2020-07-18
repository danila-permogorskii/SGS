﻿using System;
 using Newtonsoft.Json;

 namespace Entities
{
    public abstract class AuditableEntity : Entity
    {
        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
        [JsonIgnore]
        public DateTime ModifiedAt { get; set; }
        
    }
}