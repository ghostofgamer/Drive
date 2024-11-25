using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    public Slider loadingSlider;
    // public Text loadingText;
    public string sceneToLoad;

    private void Start()
    {
        gameObject.SetActive(false); // Скрываем экран загрузки при старте
    }

    public void LoadScene(string sceneName)
    {
        sceneToLoad = sceneName;
        gameObject.SetActive(true); // Показываем экран загрузки
        StartCoroutine(LoadSceneAsync(sceneName));
    }

    private IEnumerator LoadSceneAsync(string sceneName)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);
        asyncOperation.allowSceneActivation = false;

        while (!asyncOperation.isDone)
        {
            float progress = Mathf.Clamp01(asyncOperation.progress / 0.9f);
            loadingSlider.value = progress;
            // loadingText.text = (progress * 100f).ToString("F0") + "%";

            if (asyncOperation.progress >= 0.9f)
            {
                asyncOperation.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}
