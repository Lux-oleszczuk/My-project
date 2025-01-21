using UnityEngine;

public class animal : MonoBehaviour
{
    public GameObject myPrefab;
    float timestamp;
    float spawnRate = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timestamp = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.time;
        if(elapsedTime - timestamp > spawnRate)
        {
            GameObject cat = Instantiate(myPrefab, new Vector3(Random.Range(-3f, 3f), 0f, Random.Range(-13f, 3f)), Quaternion.AngleAxis(Random.Range(0, 360), Vector3.up));
            float scaleFactor = Random.Range(0.5f, 2.0f);
            cat.transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
            timestamp = elapsedTime;
        }
    }
}
