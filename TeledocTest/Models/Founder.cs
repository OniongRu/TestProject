using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeledocTest.Models
{
    public class Founder
    {
        [Key]
        public int Id { get; set; }
        public string TIN { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime AddingDate { get; set; }
        public DateTime ChangingDate { get; set; }
        
        public int ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        [InverseProperty("Founders")]
        public virtual Client Client { get; set; }
    }
}