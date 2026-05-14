using UnityEngine;

public class TargetController : MonoBehaviour
{
    GameObject player;
    TargetGeneraTte tg;

    private void Start()
    {
        player = GameObject.Find("Player");
        tg = GameObject.FindObjectOFType<TargetController>();
    }

    void Update()
    {
        transform.LookAt("player.transform");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Bomsongi"))
        {
            tg.GenerateTarget(player.transform.position);
            Destiry(gameObject);
        }
    }
}
