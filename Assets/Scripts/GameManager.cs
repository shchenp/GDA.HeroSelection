using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   [SerializeField] private PlayerManager _playerManager;
   [SerializeField] private ScreenManager _screenManager;

   private void Awake()
   {
       _playerManager.OnCoinsChanged += _screenManager.SetCoins;
       _playerManager.OnDiamondsChanged += _screenManager.SetDiamonds;
   }

   private void OnDestroy()
   {
       _playerManager.OnCoinsChanged -= _screenManager.SetCoins;
       _playerManager.OnDiamondsChanged -= _screenManager.SetDiamonds;
   }
}
