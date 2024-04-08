using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelText : MonoBehaviour
{
    public static int levelIndex;
    
    public TextMeshProUGUI levelText;

    private void Awake()
    {
        string[] split = SceneManager.GetActiveScene().name.Split(char.Parse(" "));
        levelIndex = int.Parse(split[1]);
        levelText.text = "Level " + levelIndex;
    }
}
