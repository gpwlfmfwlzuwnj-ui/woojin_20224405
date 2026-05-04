using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject BamsongiPrefabs;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bamsongi = Instantiate(BamsongiPrefabs);
            bamsongi.transform.position = transform.position;

            //Vector3 dir = new Vector3(0, 200, 2000);
            //bamsoni.GetComponent<BamsongiController>().Shoot(dir);
        }
    }
}
