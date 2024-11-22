using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    [SerializeField] private Text _coinValueText;

    private int _diamonds;

    private void Start()
    {
        _diamonds = PlayerPrefs.GetInt("NumberOfDiamonds", 0);
        _coinValueText.text = _diamonds.ToString();
    }

    public void AddDiamonds(int diamonds)
    {
        if (diamonds <= 0) return;

        _diamonds += diamonds;
        _coinValueText.text = _diamonds.ToString();
        PlayerPrefs.SetInt("NumberOfDiamonds", _diamonds);
    }
}