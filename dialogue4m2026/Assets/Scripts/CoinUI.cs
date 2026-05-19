using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCollected += UpdateCoins;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCollected -= UpdateCoins;
    }

    void UpdateCoins(int value)
    {
        coinText.text = "Moedas: " + value;
    }
}