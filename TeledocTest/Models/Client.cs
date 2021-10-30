using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeledocTest.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "ИНН")]
        [Required(ErrorMessage = "Required")]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "ИНН - 12 цифр")]
        public string TIN { get; set; }
        public string Name { get; set; }
        public bool Type { get; set; }
        public DateTime AddingDate { get; set; }
        public DateTime ChangingDate { get; set; }
        [InverseProperty(nameof(Founder.Client))]
        public virtual ICollection<Founder> Founders { get; set; }
    }
}