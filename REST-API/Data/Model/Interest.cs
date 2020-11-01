using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Hand_In_2.Data.Model
{
    public class Interest
    {
        [Key]
        public string Type { get; set; }

        [JsonIgnore]
        public List<ChildInterest> ChildInterests { get; set; }
    }
}