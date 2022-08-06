using Newtonsoft.Json;
using SGS.DataLayer.Interfaces;
using SGS.DataLayer.Models;

namespace SGS.DataLayer
{
    public class JsonWorker : IJsonWorker
    {
        public async Task<string> LoadJson()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://www.cbr-xml-daily.ru/daily_json.js");
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        public List<Currency> DeserializeJson()
        {
            var response = LoadJson().Result;
            JsonInfo jsonInfo = new JsonInfo();
            JsonTextReader reader = new JsonTextReader(new StringReader(response));
            JsonSerializer serializer = new JsonSerializer();
            jsonInfo = serializer.Deserialize<JsonInfo>(reader);
            List<Currency> currencies = new List<Currency>();
            foreach (Currency currency in jsonInfo.CurrencyDictionary.Values)
            {
                currencies.Add(currency);
            }
            return currencies;

        }


    }
}
