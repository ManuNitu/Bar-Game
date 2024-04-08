using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionPanel : MonoBehaviour
{
    public static TransitionPanel Instance { get; private set; }

    private Animator anim;
    private string sceneToTransition;

    private void Awake()
    {
        if (!Instance)
            Instance = this;
        else
            Destroy(this.gameObject);

        anim = GetComponent<Animator>();
    }

    public void TransitionDelay(string sceneName, float time)
    {
        StartCoroutine(Delay(sceneName, time));
    }

    public void Transition(string sceneName)
    {
        anim.SetTrigger("transition");
        sceneToTransition = sceneName;
    }

    public void LoadTheScene()
    {
        SceneManager.LoadScene(sceneToTransition);
    }

    IEnumerator Delay(string sceneName, float time)
    {
        yield return new WaitForSeconds(time);
        Transition(sceneName);
    }
}
