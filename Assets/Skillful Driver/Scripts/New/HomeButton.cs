using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour
{
    public void ClickToHome()=> SceneManager.LoadScene("MainMenu");
}
