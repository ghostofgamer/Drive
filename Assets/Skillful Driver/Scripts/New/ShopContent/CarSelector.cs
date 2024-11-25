using UnityEngine;

public class CarSelector : MonoBehaviour
{
    [SerializeField] private SelectCar[] _cars;

    public void SelectCar(int index)
    {
        for (int i = 0; i < _cars.Length; i++)
        {
            if(i==index)
                _cars[i].Select();
            
            _cars[i].Unselect();
        }
    }
}
