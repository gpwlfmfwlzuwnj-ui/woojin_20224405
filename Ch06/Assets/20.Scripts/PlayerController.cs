using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float jumpForce = 400f;
    float walkForce = 30f;
    float maxwalkSpeed = 1f;

    public Sprite[] walkSprites;
    public float animationPeriod = 0.1f;
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
        if(time > animationPeriod)
        {
            time = 0;
            sr.sprite = walkSprites[idx];
            idx = 1 - idx;
        }
    }
}
