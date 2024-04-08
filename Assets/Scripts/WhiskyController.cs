using UnityEngine;
using UnityEngine.UI;

public class WhiskyController : MonoBehaviour
{
    public float moveSpeed;
    public float forwardSpeed;
    public float camShakeForce;
    public float camShakeDuration;
    public Sprite[] hpSprites;
    public GameObject[] whiskyLevels;
    public GameObject whiskyGlassBreakSound;

    private bool finished;
    private int hp = 3;
    private float inputDirection;
    private Rigidbody rb;
    private Image hpImage;
    private MeshDestroy meshDestroy;
    private GameObject lastCollision;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        meshDestroy = GetComponent<MeshDestroy>();

        hpImage = GameObject.FindGameObjectWithTag("hpImage").GetComponent<Image>();
        hpImage.sprite = hpSprites[hp];

        Invoke("StartMoving", 2f);
    }

    private void FixedUpdate()
    {
        if (finished)
            return;

        Vector3 forwardMove = transform.forward * forwardSpeed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * inputDirection * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    private void Update()
    {
        inputDirection = Input.GetAxisRaw("Horizontal");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "finish")
        {
            TransitionPanel.Instance.Transition("Win Scene");
            finished = true;
        }

        if (collision.gameObject.tag == "bottle")
        {
            if(lastCollision && lastCollision == collision.gameObject)
                return;

            collision.gameObject.GetComponent<Obstacle>().ShatterObject();
            TakeDamage();

            lastCollision = collision.gameObject;
        }

        if(collision.gameObject.tag == "solid")
        {
            if (lastCollision && lastCollision == collision.gameObject)
                return;

            collision.gameObject.GetComponent<Obstacle>().ThrowObject();
            TakeDamage();

            lastCollision = collision.gameObject;
        }
    }

    void TakeDamage()
    {
        hp--;

        CameraShake.Instance.ShakeCamera(camShakeForce, camShakeDuration);

        whiskyLevels[hp].SetActive(false);

        if (hp >= 1)
            whiskyLevels[hp - 1].SetActive(true);
        hpImage.sprite = hpSprites[hp];

        if (hp == 0)
        {
            Instantiate(whiskyGlassBreakSound, transform.position, Quaternion.identity);
            TransitionPanel.Instance.TransitionDelay("Lose Scene", 1.25f);
            meshDestroy.DestroyMesh();
            
        }
    }
}
