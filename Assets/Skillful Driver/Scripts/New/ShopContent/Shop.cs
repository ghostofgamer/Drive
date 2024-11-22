using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private Sprite[] _sprites;
    [SerializeField] private GameObject[] _ownCars;
    [SerializeField] private GameObject[] _shopCars;

    private void Start()
    {
        LoadCar();
    }

    public void LoadCar()
    {
        for (int i = 0; i < _sprites.Length; i++)
        {
            int buyed = PlayerPrefs.GetInt("car" + i, 0);

            if (buyed > 0)
            {
                _ownCars[i].SetActive(true);
                _shopCars[i].SetActive(false);
            }
            else
            {
                _shopCars[i].SetActive(true);
                _ownCars[i].SetActive(false);
            }
        }
    }
}