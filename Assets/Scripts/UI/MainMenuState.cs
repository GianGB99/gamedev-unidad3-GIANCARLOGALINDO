using UnityEngine;

public class MainMenuState : UIState
{
    private GameObject _panel;

    public MainMenuState(UIManager uiManager, GameObject panel) : base(uiManager)
    {
        _panel = panel;
    }

    public override void Enter()
    {
        _panel.SetActive(true);
    }

    public override void Exit()
    {
        _panel.SetActive(false);
    }
}
