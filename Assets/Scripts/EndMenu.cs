using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndMenu : MonoBehaviour
{
    public void PlayNext()
    {
        if (Level.levelIndex == 3)
            MainMenu();
        else
            TransitionPanel.Instance.Transition("Level " + (Level.levelIndex + 1));
    }
    public void Retry()
    {
        TransitionPanel.Instance.Transition("Level " + (Level.levelIndex));
    }
    public void MainMenu()
    {
        TransitionPanel.Instance.Transition("Main Menu");
    }
}
