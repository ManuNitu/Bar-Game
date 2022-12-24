using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public Transform[] positions;
    public GameObject[] obstacles;
    private void Awake()
    {
        for (int i = 0; i < positions.Length; i++)
        {
            int rand = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[rand], positions[i].position, Quaternion.identity);
        }
        
    }
}
