using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float jumpForce = 40.0f;


    Rigidbody rb;
    Animator anim;
    GameObject director;

    Vector3 moveDirection;

    float xInput;
    float zInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

        director = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        zInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            anim.SetTrigger("Jump");
            
            return;
        }

        moveDirection = new Vector3(xInput, 0f, zInput);

        if (moveDirection.magnitude > 0.1f)
        {
            moveDirection.Normalize();
            anim.SetBool("Walking", true);
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
        }
        else
        {
            anim.SetBool("Walking", false);
        }
        if (transform.position.y < -3f)
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bomb")
        {
            Debug.Log("ÆøÅº¿¡ ¸Â¾Ò´Ù!");

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }

        Destroy(other.gameObject);
    }
}
