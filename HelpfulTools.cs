using System.Text.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace C_HelpfulPatterns
{
    public class MyData { public string? Data { get; set; } }
    public class HelpfulTools
    {
        string jsonString = "{\"data\":\"key=IAfpK, age=58, key=WNVdi, age=64, key=jp9zt, age=47, key=0Sr4C, age=68, key=CGEqo, age=76, key=IxKVQ, age=79\"}";

        public HelpfulTools()
        {
            //string jsonData = JsonToObject(jsonString);
            //var pairs = jsonData.Split(',');
            //List<(string key, int age)> list = PairsToList(pairs);
            //int result = GetAllAgeStartsFrom50(list);

            Console.WriteLine(GetAllAgeStartsFrom50(PairsToList(JsonToObject(jsonString)?.Split(',') ?? Array.Empty<string>())));
        }

        private string? JsonToObject(string jsonString)
        {
            //using JsonDocument doc = JsonDocument.Parse(jsonString);
            //string data = doc.RootElement.GetProperty("data").ToString();

            //JObject jObject = JObject.Parse(jsonString);
            //string data1 = jObject["data"]?.ToString();

            MyData? myData = JsonConvert.DeserializeObject<MyData>(jsonString);

            return myData?.Data;
        }

        private List<(string key, int age)> PairsToList(string[] pairs)
        {
            List<(string key, int age)> list = new List<(string key, int age)>();

            for (int i = 0; i < pairs.Length; i += 2)
            {
                string key = pairs[i].Split('=')[1];
                int age = int.Parse(pairs[i+1].Split("=")[1]);
                list.Add((key, age));
            }

            return list;
        }

        private int GetAllAgeStartsFrom50(List<(string key, int age)> list)
        {
            //int result = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i].age >= 50) { result++; }
            //}
            //return result;
            return list.Count(item => item.age >= 50);
        }
    }
}
