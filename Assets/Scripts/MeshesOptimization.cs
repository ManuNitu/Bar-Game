using UnityEngine;

public class MeshesOptimization : MonoBehaviour
{
    public GameObject meshes;

    private float disableDistance = 30f;
    private GameObject mainCam;
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera");

        if (GetComponent<MeshRenderer>() != null)
            meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        float camDistance = Vector3.Distance(transform.position, mainCam.transform.position);

        if (camDistance > disableDistance)
        {
            meshes.SetActive(false);

            if (meshRenderer != null)
                meshRenderer.enabled = false;
        }
        else
        {
            meshes.SetActive(true);

           
            if (meshRenderer != null)
                meshRenderer.enabled = true;
        }
    }
}
