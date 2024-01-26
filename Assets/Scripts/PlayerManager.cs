using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public event Action<int> OnCoinsChanged;
    public event Action<int> OnDiamondsChanged;
    
    //public int Coins => _coins;
    //public int Diamonds => _diamonds;
    
    [SerializeField] 
    private int _coins;
    [SerializeField]
    private int _diamonds;

    private void Start()
    {
        OnCoinsChanged?.Invoke(_coins);
        OnDiamondsChanged?.Invoke(_diamonds);
    }
}
