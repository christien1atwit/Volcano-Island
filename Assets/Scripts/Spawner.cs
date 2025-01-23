using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float timer;
    public float timeBetweenSpawns;
    
    public GameObject enemy;
    void Start()
    {
        timer = timeBetweenSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < 0)
        {
            Vector3 pos = new Vector3(Random.Range(-8.0f, 8.0f),6.0f,0f);
            Instantiate(enemy, pos, Quaternion.identity);

            timer = timeBetweenSpawns;
        }
        else
        {
            timer -= Time.deltaTime;
        }


    }
}
