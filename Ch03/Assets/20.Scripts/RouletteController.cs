using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float startSpeed = 10f;
    public float decreasesRatio = 0.96f;
    float rotSpeed = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rotSpeed = startSpeed;
        }

        transform.Rotate(0, 0, rotSpeed);

        rotSpeed *= decreasesRatio;

    
    }
}
