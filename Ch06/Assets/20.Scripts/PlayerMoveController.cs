using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    float jumpForce = 400f;
    public float walkForce = 7f;
    float maxwalkSpeed = 1f;
    Animator anim;

    public Sprite[] walkSprites;
    public Sprite jumpSprite;
    public float animationPeriod = 0.2f;
    float time = 0;
    int idx = 0;
    int key = 0;
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
        key = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }

        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if (Input.GetMouseButtonDown(0) &&
                rb.linearVelocityY == 0)
        {
            rb.AddForce(transform.up * jumpForce);
        }

        if (rb.linearVelocityX < maxwalkSpeed)
        {

            rb.AddForce(transform.right * walkForce * key);
        }

        time += Time.deltaTime;

        if (rb.linearVelocityY != 0)
        {
            anim.SetBool("IsJumping", true);
        }
        else //if (time > animationPeriod)
        {
            anim.SetBool("IsJumping", false);
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

    anim.speed = rb.linearVelocityX;

    if (transform.position.y< -8)
    {
        Debug.Log("¶³¾îÁü");
    }
private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("¼º°ø");
    }
}
