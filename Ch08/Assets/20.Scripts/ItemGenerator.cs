using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefabs;
    public GameObject bombPrefabs;

    public float span = 2f;
    public int ratio = 3; // 30% Bomb
    float delta = 0f;
    

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        GameObject item;
        if (delta > span)
        {
            int dice = Random.Range(0, 10);
            
            if (dice > ratio)
            {
                item = Instantiate(applePrefabs);
            }
            else
            {
                item = Instantiate(bombPrefabs);
            }
            // GameObject item = Instantiate(applePrefabs);
            
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            item.transform.SetParent(transform);
            item.transform.position = new Vector3(x, 7, z);

            delta = 0;
        }
    }
}