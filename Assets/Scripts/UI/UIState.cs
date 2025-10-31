using UnityEngine;

public abstract class UIState
{
    protected UIManager _uiManager;

    public UIState(UIManager uiManager)
    {
        _uiManager = uiManager;
    }

    public abstract void Enter();
    public abstract void Exit();
}
