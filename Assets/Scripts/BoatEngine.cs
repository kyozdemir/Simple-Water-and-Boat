using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatEngine : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    public float acceleration = 1f;
    public float speed;
    public float maxSpeed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (speed <= maxSpeed)
        {
            speed += acceleration;
        }
        rb.velocity = new Vector3(speed, 0f, 0f);

    }
}
