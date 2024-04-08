using UnityEngine;

public class EndMenu : MonoBehaviour
{
    public void PlayNext()
    {
        if (LevelText.levelIndex == 3)
            MainMenu();
        else
            TransitionPanel.Instance.Transition("Level " + (LevelText.levelIndex + 1));
    }

    public void Retry()
    {
        TransitionPanel.Instance.Transition("Level " + (LevelText.levelIndex));
    }

    public void MainMenu()
    {
        TransitionPanel.Instance.Transition("Main Menu");
    }
}
