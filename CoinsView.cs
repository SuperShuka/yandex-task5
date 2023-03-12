using UnityEngine;
using UnityEngine.UI;

public class CoinsView
{
    [SerializeField] private Text _render;
    [SerializeField] private Animator _animator;

    public void AnimateCoins(int amount)
    {
        _render.text = $"Coins: {amount}";
        _animator.SetTrigger("OnPickupCoin");
    }
}
