using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float jumpForce = 400f;
    public float walkForce = 7f;
    float maxwalkSpeed = 1f;
    Animatior anim;

    public Sprite[] walkSprites;
    public Sprite jumpSprite;
    public float animationPeriod = 0.2f;
    float time = 0;
    int idx = 0;
    SpriteRenderer sr;

    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * jumpForce);
        }

        if (rb.linearVelocityX < maxwalkSpeed)
        {

            rb.AddForce(transform.right * walkForce);
        }

        time += Time.deltaTime;

        if (rb.linearVelocityY != 0)
        {
            anim.SetBool("IsJumping", false);
        }
        else if (time > animationPeriod)
        {
            time = 0;
        }
    }
        //if (rb.linearVelocityY != 0)
        //{
        //    sr.sprite = jumpSprite;
        //}
        //else if (time > animationPeriod)
        //{
        //    time = 0;
        //    sr.sprite = walkSprites[idx];
        //    idx++;
        //    if (idx == walkSprites.Length)
        //    {
        //        idx = 0;
        //    }
        //}

        private void OnTriggerEnter(Collider other)
        {
    Debug.Log("¼º°ø");
        }
}
