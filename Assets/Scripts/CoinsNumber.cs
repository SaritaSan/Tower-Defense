using UnityEngine;
using UnityEngine.Events;

public class CoinsNumber : MonoBehaviour
{
    [SerializeField]
    private int _coins = 0;
    [SerializeField]
    private UnityEvent<int> _onCoinsUpdate;
    [SerializeField]
    private UnityEvent _onPurchasedSuccess;
    [SerializeField]
    private UnityEvent _onPurchasedFailure;
    public void AddCoin(int amount)
    {
        _coins += amount;
        _onCoinsUpdate?.Invoke(_coins);
    }
    public void SetCoins(int amount)
    {
        _coins = amount;
        _onCoinsUpdate?.Invoke(_coins);
    }
    public void SubtractCoins(int amount)
    {
        _coins -= amount;
        _onCoinsUpdate?.Invoke(_coins);
    }

    public bool BuyObject(int cost)
    {
        if (_coins >= cost)
        {
            _onPurchasedSuccess?.Invoke();
            SubtractCoins(cost);
            return true;
        }
        _onPurchasedFailure?.Invoke();
        return false;
    }
}
