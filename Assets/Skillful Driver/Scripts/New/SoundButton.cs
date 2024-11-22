using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    [SerializeField]private Image _image;
    [SerializeField]private Sprite _onSprite;
    [SerializeField]private Sprite _offSprite;
    
    private bool _isSoundOn;
    
    private void Start()
    {
        float soundValue = PlayerPrefs.GetFloat("SoundVolume",1);
        
        if (soundValue > 0)
        {
            _image.sprite = _onSprite;
            _isSoundOn = true;
            AudioListener.volume = 1;
        }
        else
        {
            _image.sprite = _offSprite;
            AudioListener.volume = 0;
            _isSoundOn = false;
        }
    }

    public void ChangeValue()
    {
        if (_isSoundOn)
        {
            AudioListener.volume = 0;
            _image.sprite = _offSprite;
            _isSoundOn = false;
            PlayerPrefs.SetFloat("SoundVolume", 0);
        }
        else
        {
            AudioListener.volume = 1;
            _image.sprite = _onSprite;
            _isSoundOn = true;
            PlayerPrefs.SetFloat("SoundVolume", 1);
        }
    }
}
