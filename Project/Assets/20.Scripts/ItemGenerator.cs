using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject bombPrefabs;

    public float span = 2f;
    float delta = 0f;


    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        GameObject item;
        if (delta > span)
        {
            item = Instantiate(bombPrefabs);


            float x = Random.Range(-4.4f, 10.4f);
            float z = Random.Range(-7.4f, 7.4f);
            item.transform.SetParent(transform);
            item.transform.position = new Vector3(x, 15, z);

            delta = 0;
        }
    }
}