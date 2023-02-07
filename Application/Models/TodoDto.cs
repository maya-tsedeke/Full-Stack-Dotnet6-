using Newtonsoft.Json;
using Core.Enums;

namespace Application.Models
{

    public class TodoDto
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public int Status { get; set; } = (int)TodoStatusEnum.Todo;

        [JsonIgnore]
        public DateTime? CreateDate { get; set; }

        [JsonIgnore]
        public DateTime? UpdateDate { get; set; }
        [JsonIgnore]
        public int? CreatedBy { get; set; }
        [JsonIgnore]
        public int? UpdatedBy { get; set; }

    }
}
