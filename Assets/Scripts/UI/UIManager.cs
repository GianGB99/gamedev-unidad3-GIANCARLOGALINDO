using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Referencias a los paneles
    [Header("Paneles del Canvas")]
    public GameObject mainMenuPanel;
    public GameObject inGameHUDPanel;
    public GameObject pauseMenuPanel;

    // Estado actual
    private enum UIState { MainMenu, InGame, Paused }
    private UIState currentState;

    private void Start()
    {
        // Inicia en el menú principal
        ShowMainMenu();
    }

    // --- Métodos principales ---
    public void ShowMainMenu()
    {
        currentState = UIState.MainMenu;

        mainMenuPanel.SetActive(true);
        inGameHUDPanel.SetActive(false);
        pauseMenuPanel.SetActive(false);

        Time.timeScale = 1f; // Asegura que el juego no esté pausado
    }

    public void StartGame()
    {
        currentState = UIState.InGame;

        mainMenuPanel.SetActive(false);
        inGameHUDPanel.SetActive(true);
        pauseMenuPanel.SetActive(false);

        Time.timeScale = 1f;
    }

    public void PauseGame()
    {
        if (currentState == UIState.InGame)
        {
            currentState = UIState.Paused;

            mainMenuPanel.SetActive(false);
            inGameHUDPanel.SetActive(false);
            pauseMenuPanel.SetActive(true);

            Time.timeScale = 0f; // Detiene el tiempo del juego
        }
    }

    public void ResumeGame()
    {
        currentState = UIState.InGame;

        mainMenuPanel.SetActive(false);
        inGameHUDPanel.SetActive(true);
        pauseMenuPanel.SetActive(false);

        Time.timeScale = 1f; // Reanuda el tiempo
    }

    public void ExitGame()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }

    private void Update()
{
    if (Input.GetKeyDown(KeyCode.Escape))
    {
        if (currentState == UIState.InGame)
            PauseGame();
        else if (currentState == UIState.Paused)
            ResumeGame();
    }
}

}
