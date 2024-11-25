using UnityEngine;

public class BuyCar : MonoBehaviour
{
    [SerializeField] private int _index;
    [SerializeField] private Shop _shop;
    [SerializeField] private int _price;
    [SerializeField] private Wallet _wallet;
    
    public void Buy()
    {
        if (_wallet.Diamonds < _price)
            return;
        
        _wallet.DecreaseDiamonds(_price);
        PlayerPrefs.SetInt("car" + _index, 1);
        _shop.LoadCar();
    }
}
