namespace MagicVilla_VillaAPI.Models.Dto
{
    public class LoginResponseDTO
    {
        //public LocalUser User { get; set; }
        public UserDTO User { get; set; }

        //public string Role { get; set; }  // we dont need this, cause we already have token that has the claim of role with the appropriate role
        public string Token { get; set; }
    }
}
