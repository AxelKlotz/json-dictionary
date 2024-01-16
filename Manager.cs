using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonDictionary
{
    public class Manager
    {
        //Json till dictionary


        //Dictionary till Json
        public string CreateJsonFromDict(Dictionary<string, object> dict)
        {
            if (dict == null)
                throw new ArgumentNullException();
            else if (!dict.Any())
                throw new ArgumentException();
            else if (dict.ContainsValue(null))
                throw new NullReferenceException();

            string json = JsonConvert.SerializeObject(dict);
            return json;

        }

        //Läsa Json fil


        //Skriv Json fil
        public void WriteJsonFile(string json, string fileName)
        {
            if (IsValidJson(json))
            {
                string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
                File.WriteAllText(filePath, json);
            }

        }


        /// <summary>
        /// Validates a string as JSON. If invalid JSON, this method will throw a JsonReaderException.
        /// </summary>
        /// <param name="stringToValidate"></param>
        /// <returns>Returns true if input is correct JSON format, otherwise throws JsonReaderException.</returns>
        /// <exception cref="JsonReaderException"></exception>
        private bool IsValidJson(string stringToValidate)
        {
            JToken.Parse(stringToValidate);
            return true;
        }
    }
}
