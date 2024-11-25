using UnityEngine;

public class BuyCar : MonoBehaviour
{
    [SerializeField] private int _index;
    [SerializeField] private Shop _shop;
    
    public void Buy()
    {
        PlayerPrefs.SetInt("car" + _index, 1);
        Debug.Log(  PlayerPrefs.GetInt("car" + _index, 0));
        _shop.LoadCar();
    }
}
