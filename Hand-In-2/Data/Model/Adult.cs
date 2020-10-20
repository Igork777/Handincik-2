using System.Text.Json;

namespace Hand_In_2.Data.Model
{
    public class Adult : Person {
        public string JobTitle { get; set; }

        public override string ToString() {
            return JsonSerializer.Serialize(this);
        }

        public void Update(Adult toUpdate) {
            JobTitle = toUpdate.JobTitle;
            base.Update(toUpdate);
        }

    }
}