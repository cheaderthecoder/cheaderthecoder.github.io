using System;
using System.Text.Json;

public class TXTtoJSON
{
    public static async Task<string> LoadWords()
    {
        using (HttpClient client = new HttpClient())
        {
            Console.WriteLine("Connecting");
            string content = await client.GetStringAsync("https://darkermango.github.io/5-Letter-words/words.txt");
            string[] lines = content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> wordList = lines.ToList();

            // Create an anonymous object with the word list nested under a "words" key
            var wordObject = new { words = wordList };

            // Convert the object to a JSON string
            string jsonObject = JsonSerializer.Serialize(wordObject, new JsonSerializerOptions { WriteIndented = true });

            return jsonObject;
        }
    }

    public static async Task Main(string[] args)
    {
        string jsonWords = await LoadWords();
        await File.WriteAllTextAsync("words.json", jsonWords);
        Console.WriteLine(jsonWords);
        Console.ReadKey();
    }
}
