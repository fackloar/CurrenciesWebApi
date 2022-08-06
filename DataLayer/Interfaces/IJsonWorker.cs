using SGS.DataLayer.Models;

namespace SGS.DataLayer.Interfaces
{
    public interface IJsonWorker
    {
        public Task<string> LoadJson();
        public List<Currency> DeserializeJson();

    }
}
