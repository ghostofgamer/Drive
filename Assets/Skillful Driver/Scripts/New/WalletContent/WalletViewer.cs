using UnityEngine;
using UnityEngine.UI;

public class WalletViewer : MonoBehaviour
{
    [SerializeField] private Text _coinValueText;
    [SerializeField] private Wallet _wallet;

    private void Awake()
    {
        _coinValueText.text = PlayerPrefs.GetInt("NumberOfDiamonds", 0).ToString();
    }

    private void OnEnable()
    {
        _wallet.DiamondsValueChanged += ShowDiamondTextValue;
    }

    private void OnDisable()
    {
        _wallet.DiamondsValueChanged -= ShowDiamondTextValue;
    }

    private void ShowDiamondTextValue(int value)
    {
        _coinValueText.text = value.ToString();
    }
}