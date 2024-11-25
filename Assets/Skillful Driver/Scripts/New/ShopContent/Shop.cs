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
        for (int i = 0; i < _ownCars.Length; i++)
        {
            int buyed = PlayerPrefs.GetInt("car" + i, 0);

            if (i == 0)
            {
                buyed = 1;

                /*if (PlayerPrefs.GetInt("ChoosenItem", 0) == 0)
                    _ownCars[i].GetComponent<SelectCar>().Select();*/
            }


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

        int selectedCar = PlayerPrefs.GetInt("ChoosenItem", 0);
        _ownCars[selectedCar].GetComponent<SelectCar>().Select();
    }

    public void ChangeSelectedCar()
    {
    }
}