using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBottles : MonoBehaviour
{
    [Range(1,2)]
    public int amount;
    public List<Transform> spawnPoints;
    public GameObject[] Bottles;
    private void Awake()
    {
        for(int i = 0; i < amount; i++)
        {
            int randPos = Random.Range(0, spawnPoints.Count);
            float randRot = Random.Range(100f, 260f);
            int randObj = Random.Range(0, Bottles.Length);
            Instantiate(Bottles[randObj], spawnPoints[randPos].position, Quaternion.Euler(0f,randRot,0f));
            spawnPoints.Remove(spawnPoints[randPos]);
        }
    }
}
