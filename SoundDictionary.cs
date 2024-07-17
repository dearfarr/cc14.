using System.Collections.Generic;

public static class SoundDictionary
{
    private static Dictionary<int, List<string>> vulpakinSounds = new Dictionary<int, List<string>>()
    {
        { 4, new List<string> { "Рррр", "Гррр" } },
        { 5, new List<string> { "Рааар", "Гхафф" } },
        { 6, new List<string> { "Рррррр", "Гррррр" } }
    };

    private static Dictionary<int, List<string>> arachnidSounds = new Dictionary<int, List<string>>()
    {
        { 4, new List<string> { "Хссс", "Сссс" } },
        { 5, new List<string> { "Хххсс", "Ссссс" } },
        { 6, new List<string> { "Хссссс", "Сссссс" } }
    };

    private static string rodentSound = "Пииим";

    public static string TranslateToVulpakin(int wordLength)
    {
        return vulpakinSounds.ContainsKey(wordLength) ? vulpakinSounds[wordLength][new System.Random().Next(0, vulpakinSounds[wordLength].Count)] : "???";
    }

    public static string TranslateToArachn
      public static string TranslateToArachnid(int wordLength)
    {
        return arachnidSounds.ContainsKey(wordLength) ? arachnidSounds[wordLength][new System.Random().Next(0, arachnidSounds[wordLength].Count)] : "???";
    }

    public static string TranslateToRodent()
    {
        return rodentSound;
    }
}
