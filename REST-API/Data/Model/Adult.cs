using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace Hand_In_2.Data.Model
{
    public class Adult : Person {
        public static string Path { get; set; }
        
        [Required, NotNull]
        public string JobTitle { get; set; }

        static Adult()
        {
            Path = "adults.json";
        }

        public override string ToString() {
            return JsonSerializer.Serialize(this);
        }

        public void Update(Adult toUpdate) {
            JobTitle = toUpdate.JobTitle;
            base.Update(toUpdate);
        }

    }
}