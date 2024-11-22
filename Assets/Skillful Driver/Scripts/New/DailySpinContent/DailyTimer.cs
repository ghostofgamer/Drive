using System;
using UnityEngine;
using UnityEngine.UI;

public class DailyTimer : MonoBehaviour
{
    public Button[] buttonSpin;
    private DateTime lastTimesSpin;

    private void Start()
    {
        if (PlayerPrefs.HasKey("LastSpin"))
        {
            string key = "LastPressTime";
            string lastPressTimeString = PlayerPrefs.GetString(key);
            lastTimesSpin = DateTime.Parse(lastPressTimeString);
            CheckButtonAvailability();
        }
        else
        {
            lastTimesSpin = DateTime.MinValue;
        }
    }

    void CheckButtonAvailability()
    {
        string key = "LastPressTime";

        if (PlayerPrefs.HasKey(key))
        {
            string timing = PlayerPrefs.GetString("LastPressTime");
            DateTime tim;

            if (DateTime.TryParse(timing, out tim))
            {
                
                if (DateTime.Now - tim >= TimeSpan.FromHours(24))
                {
                    foreach (var button in buttonSpin)
                        button.interactable = true;
                }
                else
                {
                    foreach (var button in buttonSpin)
                        button.interactable = false;
                } 
            }
        }
        else
        {
            foreach (var button in buttonSpin)
                button.interactable = true;
        }
    }

    void Update()
    {
        string timing = PlayerPrefs.GetString("LastPressTime");

        if (!string.IsNullOrEmpty(timing))
        {
            DateTime tim;
            if (DateTime.TryParse(timing, out tim))
            {
                if (DateTime.Now - tim >= TimeSpan.FromHours(24))
                    CheckButtonAvailability();
            }
            else
            {
                Debug.LogError("Не удалось преобразовать строку в DateTime: " + timing);
            }
        }
    }

   public  void OnButtonClick()
    {
        lastTimesSpin = DateTime.Now;
        PlayerPrefs.SetString("LastPressTime", DateTime.Now.ToString());
        PlayerPrefs.SetString("LastSpin", "крути");
        PlayerPrefs.Save();
        
        foreach (var button in buttonSpin)
            button.interactable = false;
    }
}