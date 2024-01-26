using UnityEngine;
using Extensions;
using Screen = Extensions.Screen;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private Screen _lobbyScreen;
    [SerializeField] private Screen _heroSelectorScreen;

    public void SetCoins(int coins)
    {
        _lobbyScreen.SetCoins(coins);
        _heroSelectorScreen.SetCoins(coins);
    }

    public void SetDiamonds(int diamonds)
    {
        _lobbyScreen.SetDiamonds(diamonds);
        _heroSelectorScreen.SetDiamonds(diamonds);
    }
}
