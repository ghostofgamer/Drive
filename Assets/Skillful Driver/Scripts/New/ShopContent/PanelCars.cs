using UnityEngine;

public class PanelCars : MonoBehaviour
{
    [SerializeField] private bool _isShopCarPanel;

    private void Start()
    {
        int lastPanel = PlayerPrefs.GetInt("LastPanel", 0);

        if (lastPanel > 0)
        {
            if (_isShopCarPanel)
                gameObject.SetActive(false);
        }
        else
        {
            if (!_isShopCarPanel)
                gameObject.SetActive(false);
        }
    }
}