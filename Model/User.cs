using Microsoft.AspNetCore.Identity;
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
        [Column("Email")]
     public string? Email { get; set; }
        [Required]
        [Column("UserName")]
        public string? UserName { get; set; }
        [Required]
        [Column("Password")]
        public string? Password { get; set; }

        [Required]
        [Column("MobileNo")]
        public string? MobileNo { get; set; }
        
        [ForeignKey("GetRole")]
        public int RoleId { get; set; }
        public UserRole GetRole { get; set; } 





        public override string ToString()
        {
            return $"UserId: {UserId}, EmailId: {Email},UserName:{UserName},RoleId:{RoleId}, Password: {Password}, MobileNo: {MobileNo}";
        }
    }
}
