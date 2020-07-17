﻿namespace Entities
{
    public abstract class AbsValute
    {
        public virtual string Id { get; set; } 
        public virtual string NumCode { get; set; } 
        public virtual string CharCode { get; set; } 
        public virtual int Nominal { get; set; } 
        public virtual string Name { get; set; } 
        public virtual double Value { get; set; } 
        public virtual double Previous { get; set; }
    }
}