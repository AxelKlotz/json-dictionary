using Newtonsoft.Json;

namespace JsonDictionary
{
    public class Manager
    {
        //Json till dictionary


        //Dictionary till Json
        public string CreateJsonFromDict(Dictionary<string, object> dict)
        {
            if (!dict.Any())
            {
                throw new ArgumentException();
            }
            else
            {
                string json = JsonConvert.SerializeObject(dict);
                return json;
            }

        }

        //Läsa Json fil


        //Skriv Json fil
    }
}
