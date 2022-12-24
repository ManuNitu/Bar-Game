using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Level : MonoBehaviour
{
    public static int levelIndex;
    public GameObject[] MidPieces;
    public GameObject EndPiece;
    public int lenght;
    public TextMeshProUGUI levelText;
    private void Awake()
    {
        string[] split = SceneManager.GetActiveScene().name.Split(char.Parse(" "));
        levelIndex = int.Parse(split[1]);
        levelText.text = "Level " + levelIndex;
    }
}
