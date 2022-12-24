using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject hitSoundEffect;
    private MeshDestroy meshDestroy;
    private Rigidbody rb;
    private void Awake()
    {
        meshDestroy = GetComponent<MeshDestroy>();
        rb = GetComponent<Rigidbody>();
    }
    public void ShatterObject()
    {
        Instantiate(hitSoundEffect, transform.position, Quaternion.identity);
        meshDestroy.DestroyMesh();
    }
    public void ThrowObject()
    {
        Instantiate(hitSoundEffect, transform.position, Quaternion.identity);
        rb.AddForce(new Vector3(0,3f,-0.5f), ForceMode.Impulse);
        Destroy(this.gameObject, 1.5f);
    }

}
