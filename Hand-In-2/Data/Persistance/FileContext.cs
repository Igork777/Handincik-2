using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Exercise1.Models;
using Hand_In_2.Data.Model;
using Microsoft.Extensions.FileSystemGlobbing.Abstractions;

namespace Hand_In_2.Data.Persistance
{
    public class FileContext : ISaveData
    {
        private IList<User> users { get;  }
        private IList<Family> families { get; }
        private IList<Adult> adults { get; }

        private readonly string familiesFile = "families.json";
        private readonly string adultsFile = "adults.json";
        private readonly string usersFile = "users.json";

        public FileContext() {
            families = File.Exists(familiesFile) ? ReadData<Family>(enums.families) : new List<Family>();
            adults = File.Exists(adultsFile) ? ReadData<Adult>(enums.adults) : new List<Adult>();
            users = File.Exists(familiesFile) ? ReadData<User>(enums.users) : new List<User>();

        }

        public IList<T> ReadData<T>(enums e)
        {
            string content = File.ReadAllText(e + ".json");
            return JsonSerializer.Deserialize<List<T>>(content);
        }

        public void SaveChanges(enums e, string json) {
          File.WriteAllText(e+".json", json);
        }
    }
}