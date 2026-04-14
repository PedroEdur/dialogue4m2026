using UnityEngine;

public class GameplayStart : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.ChangeState(GameManager.GameState.Gameplay);
    }
}