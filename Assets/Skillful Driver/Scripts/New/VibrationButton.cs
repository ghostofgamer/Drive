using UnityEngine;
using UnityEngine.UI;

public class VibrationButton : MonoBehaviour
{
    [SerializeField]private Image _image;
    [SerializeField]private Sprite _onSprite;
    [SerializeField]private Sprite _offSprite;
    
    private bool _isVibrating;
    
    private void Start()
    {
        int vibrationStrength = PlayerPrefs.GetInt("Vibration", 1);

        if (vibrationStrength > 0)
        {
            _image.sprite = _onSprite;
            _isVibrating = true;
        }
        else
        {
            _image.sprite = _offSprite;
            _isVibrating = false;
        }
    }

    public void ChangeValue()
    {
        if (_isVibrating)
        {
            _image.sprite = _offSprite;
            _isVibrating = false;
            PlayerPrefs.SetInt("Vibration", 0);
        }
        else
        {
            _image.sprite = _onSprite;
            _isVibrating = true;
            PlayerPrefs.SetInt("Vibration", 1);
        }
        
        
        /*if (vibrationToggle.isOn)
        {
            PlayerPrefs.SetInt("Vibration", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Vibration", 0);
        }
        buttonSound.Play();*/
    }
}
