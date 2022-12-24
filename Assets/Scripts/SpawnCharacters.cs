using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacters : MonoBehaviour
{
    public GameObject[] Characters;
    public Transform[] spawnPoints;
    private void Awake()
    {
        for(int i = 0; i < spawnPoints.Length; i++)
        {
            int rand = Random.Range(0, Characters.Length);
            Instantiate(Characters[rand], spawnPoints[i].transform.position, spawnPoints[i].transform.rotation);
        }
    }
}
