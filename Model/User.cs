using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Model
{
    [Table("User")]
    public class User
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("UserId")]
        public int UserId { get; set; }
        [Required]
        [Column("EmailId")]
     public string? EmailId { get; set; }
        [Required]
        [Column("Password")]
        public string? Password { get; set; }

        [Required]
        [Column("MobileNo")]
        public string? MobileNo { get; set; }
       

        

        /*public int RoleId { get; set; }
        public string Name { get; set; }

        public string AdharNumber { get; set; }
        public string Address { get; set; }*/

        public override string ToString()
        {
            return $"UserId: {UserId}, EmailId: {EmailId}, Password: {Password}, MobileNo: {MobileNo}";
        }
    }
}
