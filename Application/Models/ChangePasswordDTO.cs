using Newtonsoft.Json;
namespace Application.Models
{
    public class ChangePasswordModelDto
    {
        [JsonIgnore]
        public int? UserId { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordConfirmation { get; set; }
        [JsonIgnore]
        public DateTime? UpdateDate { get; set; }

    }
}
