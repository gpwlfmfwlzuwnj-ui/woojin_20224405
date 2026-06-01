using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
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

            item = Instantiate(bombPrefabs);


            float x = Random.Range(-1f, 5f);
            float z = Random.Range(-1f, 5f);
            item.transform.SetParent(transform);
            item.transform.position = new Vector3(x, 7, z);

            delta = 0;
        }
    }
}