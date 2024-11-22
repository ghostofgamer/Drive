using UnityEngine;

public class InformationButton : MonoBehaviour
{
    public string websiteURL = "https://www.maxfabrique.com/";

    public void ShowSite()
    {
        Application.OpenURL(websiteURL);
    }
}
