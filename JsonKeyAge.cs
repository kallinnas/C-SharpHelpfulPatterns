using System.Collections.ObjectModel;
using System.Text.Json;

namespace C_HelpfulPatterns;

internal class JsonKeyAge
{
    public void Run()
    {
        string jsonString = "{\"data\":\"key=IAfpK, age=58, key=WNVdi, age=64, key=jp9zt, age=47, key=0Sr4C, age=68, key=CGEqo, age=76, key=IxKVQ, age=79\"}";
        var data = GetJsonData(jsonString);
        var pairs = data.Split(',');
        var result = PairsToArray(pairs);
        DisplayResult(result);
    }

    private static void DisplayResult(Collection<(string, int)> list)
    {
        try
        {
            foreach (var pair in list)
            {
                if (pair.Item2 >= 50)
                {
                    Console.WriteLine(pair.Item1 + " " + pair.Item2);
                }
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private static Collection<(string, int)> PairsToArray(string[] pairs)
    {
        var result = new Collection<(string, int)>();

        try
        {
            for (int i = 0; i < pairs.Length; i += 2)
            {
                var key = pairs[i].Split('=')[1];
                var age = int.Parse(pairs[i + 1].Split('=')[1]);
                result.Add((key, age));
            }
        }

        catch (Exception e)
        {
            Console.Error.WriteLine(e);
        }

        return result;
    }

    private static string GetJsonData(string jsonString)
    {
        string result = "";

        try
        {
            if (!string.IsNullOrEmpty(jsonString))
            {
                var doc = JsonDocument.Parse(jsonString);
                result = doc.RootElement.GetProperty("data").ToString();
            }
        }

        catch
        {
            Console.WriteLine("jsonString IsNullOrEmpty");
        }

        return result;
    }
}
