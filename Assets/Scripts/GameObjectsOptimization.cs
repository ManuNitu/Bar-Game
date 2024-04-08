using System.Collections.Generic;
using UnityEngine;

public class GameObjectsOptimization : MonoBehaviour
{
    public string Identifier;

    private List<GameObject> furniture = new List<GameObject>();
    private float disableDistance = 30f;
    private GameObject mainCam;

    private void Awake()
    {

        mainCam = GameObject.FindGameObjectWithTag("MainCamera");

        for (int i = 0; i < transform.childCount; i++)
        {
            GameObject obj = transform.GetChild(i).gameObject;

            if (!obj.name.StartsWith(Identifier))
            {
                furniture.Add(obj);

            }

        }

    }

    private void Update()
    {
        

        float camDistance = Vector3.Distance(transform.position, mainCam.transform.position);

        if (camDistance > disableDistance)
        {
            for (int i = 0; i < furniture.Count; i++)
            {

                furniture[i].SetActive(false);
            }
        }
        else
        {
            for (int i = 0; i < furniture.Count; i++)
            {
                furniture[i].SetActive(true);
            }
        }
    }
}
