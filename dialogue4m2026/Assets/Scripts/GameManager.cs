using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public enum GameState
    {
        Iniciando,
        MenuPrincipal,
        Gameplay
    }

    public GameState currentState;

    void Awake()
    {
        // Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        ChangeState(GameState.Iniciando);
        LoadScene("Splash");
    }

    public void ChangeState(GameState newState)
    {
        currentState = newState;
        Debug.Log("Estado atual: " + currentState);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // BOTÃO JOGAR
    public void StartGame()
    {
        Debug.Log("Clicou em Jogar");

        if (currentState == GameState.MenuPrincipal)
        {
            ChangeState(GameState.Gameplay);
            LoadScene("SampleScene");
        }
        else
        {
            Debug.Log("Não está no Menu, não pode iniciar");
        }
    }

    // BOTÃO SAIR
    public void QuitGame()
    {
        Debug.Log("Clicou em Sair");
        Application.Quit();
    }

    // PARA O SPLASH CHAMAR
    public void GoToMenu()
    {
        ChangeState(GameState.MenuPrincipal);
        LoadScene("MenuPrincipal");
    }
}