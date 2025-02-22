using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Employees
{
    public class Employee
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Signature { get; set; }

        [Required]
        [DefaultValue(1)]
        public bool Active { get; set; }

        [Required]
        [DefaultValue(0001)]
        public string Position { get; set; }

        [Required]
        public DateTime InsertUpdateDatetime { get; set; }
    }
}
