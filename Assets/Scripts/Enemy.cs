using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float minSpeed;
    public float maxSpeed;
    private float speed;

    void Start()
    {
        speed = Random.Range(minSpeed,maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
