using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PausePanel;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausePanel.activeSelf)
                Resume();
            else
                Paused();
           
        }
    }
    void Paused()
    {
        AudioManager.Instance.PauseMusic();
        PausePanel.SetActive(true);

        Time.timeScale = 0f;
    }
    public void Resume()
    {
        Time.timeScale = 1f;

        AudioManager.Instance.ResumeMusic();
        PausePanel.SetActive(false);
    }
    public void MainMenu()
    {
        Resume();
        TransitionPanel.Instance.Transition("Main Menu");
    }
}
