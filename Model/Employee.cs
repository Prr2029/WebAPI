using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Model
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("EmpId")]
        public int EmpId { get; set; }
        [Required]
        [Column("FirstName")]
        public string FirstName { get; set; }
        

        public override string ToString()
        {
            return $"empid:{EmpId},firstname:{FirstName}";
        }

    }
}
