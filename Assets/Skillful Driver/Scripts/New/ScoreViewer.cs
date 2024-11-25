using TMPro;
using UnityEngine;

public class ScoreViewer : MonoBehaviour
{
    [SerializeField]private TMP_Text scoreText;
    
    private void Start()
    {
        scoreText.text= PlayerPrefs.GetInt("BestScore").ToString();
    }
}
