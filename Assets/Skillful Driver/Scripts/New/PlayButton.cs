using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void SceneGameLoad() => SceneManager.LoadScene("Game");
}