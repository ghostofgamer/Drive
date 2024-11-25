using UnityEngine;
using UnityEngine.UI;

public class ChangePanelShop : MonoBehaviour
{
    [SerializeField] private bool _isPanelShop;
    [SerializeField] private int _index;
    [SerializeField]private Image _imageButton;
    [SerializeField]private Sprite _onSprite;
    [SerializeField]private Sprite _offSprite;
    [SerializeField] private ChangePanelShop _button;

    private bool _isActive;
    
    private void Start()
    {
        int lastPanel = PlayerPrefs.GetInt("LastPanel", 0);
        Debug.Log("Last " + lastPanel);

        if (lastPanel == _index)
        {
            _imageButton.sprite = _onSprite;
            _isActive = true;
        }
        else
        {
            _imageButton.sprite = _offSprite;
            _isActive = false;
        }
    }

    public void Click()
    {
        _imageButton.sprite = _onSprite;
        _button.ChangeSpriteOtherButton();
        PlayerPrefs.SetInt("LastPanel", _index);
    }

    private void ChangeSpriteOtherButton()
    {
        _imageButton.sprite = _offSprite;
    }
}
