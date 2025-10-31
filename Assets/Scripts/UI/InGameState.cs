using UnityEngine;

public class InGameState : UIState
{
    private GameObject _panel;

    public InGameState(UIManager uiManager, GameObject panel) : base(uiManager)
    {
        _panel = panel;
    }

    public override void Enter()
    {
        _panel.SetActive(true);
        Time.timeScale = 1f;  // Reanuda el juego
    }

    public override void Exit()
    {
        _panel.SetActive(false);
    }
}
