using Newtonsoft.Json;
namespace Application.Models 
{
    public class UserDto : UserLoginDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        [JsonIgnore]
        public DateTime? CreateDate { get; set; }
        [JsonIgnore]
        public DateTime? UpdateDate { get; set; }
    }
}
