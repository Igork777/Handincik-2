using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

using System.Threading.Tasks;
using Hand_In_2.Data.Model;



namespace Hand_In_2.Data.Impl
{
    public class AdultService : IAdultsService
    {
        private HttpClient _httpClient;

        public AdultService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

      
        public async Task<IList<Adult>> getAllAdults()
        {
            var obj = await  _httpClient.GetStringAsync("Adults");
            IList<Adult> adults = Newtonsoft.Json.JsonConvert.DeserializeObject<IList<Adult>>(obj);
            return adults;
        }

        public async Task addAdult(Adult adult)
        {
            string adultSerialized = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(
                adultSerialized, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await _httpClient.PostAsync("Adults", content);
            Console.WriteLine(responseMessage);
        }

        public async Task removeAdult(string firstName, string lastName)
       
        {
            try
            {
                var obj = await _httpClient.DeleteAsync("Adults?firstname="+ firstName + "&lastname="+lastName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
           
        }
    }
}