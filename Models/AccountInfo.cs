using System.ComponentModel.DataAnnotations;

namespace OrigamiTrade.Models
{
    public class AccountInfo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [EmailAddress,Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PinCode { get; set; }
        public string CountryCode { get; set; }
        [Required]
        public string PhoneNumber { get; set; }




    }
}
