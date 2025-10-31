using UnityEngine;

public class PauseMenuState : UIState
{
    private GameObject _panel;

    public PauseMenuState(UIManager uiManager, GameObject panel) : base(uiManager)
    {
        _panel = panel;
    }

    public override void Enter()
    {
        _panel.SetActive(true);
        Time.timeScale = 0f;  // Pausa el juego
    }

    public override void Exit()
    {
        _panel.SetActive(false);
        Time.timeScale = 1f;  // Reanuda al salir
    }
}
