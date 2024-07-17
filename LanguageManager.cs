using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public Button switchLanguageButton;
    private bool isVulpakinLanguage = true;

    void Start()
    {
        switchLanguageButton.onClick.AddListener(SwitchLanguage);
    }

    void SwitchLanguage()
    {
        isVulpakinLanguage = !isVulpakinLanguage;
        Debug.Log("Language switched to " + (isVulpakinLanguage ? "Vulpakin" : "Arachnid"));
    }

    public string TranslateWord(string word)
    {
        if (word.Length == 0) return word;

        if (isVulpakinLanguage)
        {
            return SoundDictionary.TranslateToVulpakin(word.Length);
        }
        else
        {
            return SoundDictionary.TranslateToArachnid(word.Length);
        }
    }
}
