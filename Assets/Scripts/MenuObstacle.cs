using UnityEngine;

public class MenuObstacle : MonoBehaviour
{
    public float minPosX;
    public float maxPosX;
    public float minRotY;
    public float maxRotY;

    private void Awake()
    {
        float randRotY = Random.Range(minRotY, maxRotY);
        float randPosX = Random.Range(minPosX, maxPosX);
        transform.position = new Vector3(randPosX, transform.position.y, transform.position.z);
        transform.rotation = Quaternion.Euler(0f, randRotY, 0f);
    }
}
