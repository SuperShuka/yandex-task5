using System.Collections;
using UnityEngine;

public class CoinsPresenter : MonoBehaviour
{
    private CoinsModel _coinsModel = new CoinsModel(PlayerPrefs.GetInt("Coins", 0));
    private CoinsView _coinsView = new CoinsView();
    
    public void Awake()
    {
        _coinsModel.OnCoinsUpdate += SaveCoins;
        _coinsModel.OnCoinsUpdate += _coinsView.AnimateCoins;
    }

    private void SaveCoins(int amount)
    {
        PlayerPrefs.SetInt("Coins", amount);
    }
    
}