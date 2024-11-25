using UnityEngine;

public class SelectCar : MonoBehaviour
{
    [SerializeField] private int  _index;
    [SerializeField]private CarSelector _carSelector;
    [SerializeField] private GameObject _selectedPack;
    [SerializeField] private GameObject _notSelectedPack;

    public void ChangeSelectedPack()
    {
        _carSelector.SelectCar(_index);
    }
    
    public void Select()
    {
        PlayerPrefs.SetInt("ChoosenItem", _index);
        _selectedPack.SetActive(true);
        _notSelectedPack.SetActive(false);
    }

    public void Unselect()
    {
        _selectedPack.SetActive(false);
        _notSelectedPack.SetActive(true);
    }
}
