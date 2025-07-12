using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CoinsUI : MonoBehaviour
{
    [SerializeField]
    private Text _coinText;
    [SerializeField]
    private UnityEvent _onCoinsUpdate;
    public void UpdateCoins(int coinsNumber)
    {
        _coinText.text = "X" + coinsNumber;
        _onCoinsUpdate.Invoke();
    }
}
