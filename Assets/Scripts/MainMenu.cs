using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject Title;
    public GameObject Levels;
    public Animator transitionPanelAnim;

    public void Play()
    {
        Title.SetActive(false);
        Levels.SetActive(true);
    }

    public void Back()
    {
        Title.SetActive(true);
        Levels.SetActive(false);
    }

    public void PlayLevel(int index)
    {
        TransitionPanel.Instance.Transition("Level " + index);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
