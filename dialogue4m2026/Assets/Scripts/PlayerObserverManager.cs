using System;

public static class PlayerObserverManager
{
    // Evento das moedas
    public static Action<int> OnCoinCollected;

    // Método para avisar que pegou moeda
    public static void CollectCoin(int totalCoins)
    {
        OnCoinCollected?.Invoke(totalCoins);
    }
}