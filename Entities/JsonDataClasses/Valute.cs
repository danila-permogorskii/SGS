using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.JsonDataClasses
{
    public class Valute : AuditableEntity
    {
        [ForeignKey("valuteId")]
        public string ID { get; set; }
        [Column("name")]
        public string Name { get; set; } 
        [Column("nominal")]
        public int Nominal { get; set; } 
        [Column("previous")]
        public double Previous { get; set; }
        [Column("value")]
        public double Value { get; set; } 
        [Column("charCode")]
        public string CharCode { get; set; }
        [Column("numCode")]
        public string NumCode { get; set; } 

        public Valute(string valuteId, string numCode, string charCode, int nominal, string name, double value, double previous)
        {
            ID = valuteId;
            Name = name;
            Nominal = nominal;
            Previous = previous;
            Value = value;
            CharCode = charCode;
            NumCode = numCode;
        }

        //For EF Core
        public Valute()
        {
            
        }

        public override string ToString()
        {
            return ($"Id: {ID}\n" +
                    $"Name: {Name}\n" +
                    $"Nominal: {Nominal}\n" +
                    $"Previous: {Previous}\n" +
                    $"Value: {Value}\n" +
                    $"CharCode:  {CharCode}\n" +
                    $"NumCode: {NumCode}\n");
        }
    }
}