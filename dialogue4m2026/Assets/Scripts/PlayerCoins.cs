using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    private int coins = 0;

    public void AddCoin()
    {
        coins++;

        // Notifica a interface
        PlayerObserverManager.CollectCoin(coins);
    }
}