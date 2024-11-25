using System;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    private int _diamonds;

    public event Action<int> DiamondsValueChanged;

    public int DiamondThisCollectGame { get; private set; } = 0;
        
    public int Diamonds => _diamonds;
    
    private void Start()
    {
        DiamondThisCollectGame = 0;
        _diamonds = PlayerPrefs.GetInt("NumberOfDiamonds", 0);
    }

    public void IncreaseDiamonds(int diamonds)
    {
        if (diamonds <= 0) return;

        _diamonds += diamonds;
        PlayerPrefs.SetInt("NumberOfDiamonds", _diamonds);
        DiamondsValueChanged ?. Invoke(_diamonds);
    }

    public void DecreaseDiamonds(int diamonds)
    {
        _diamonds -= diamonds;
        PlayerPrefs.SetInt("NumberOfDiamonds", _diamonds);
        DiamondsValueChanged ?. Invoke(_diamonds);
    }

    public void AddCollectStat()
    {
        DiamondThisCollectGame++;
    }
}