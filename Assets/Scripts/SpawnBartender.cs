using UnityEngine;

public class SpawnBartender : MonoBehaviour
{
    public GameObject[] Bartenders;

    private void Awake()
    {
        int rand = Random.Range(0, Bartenders.Length);
        Instantiate(Bartenders[rand], transform.position, transform.rotation);
    }
}
