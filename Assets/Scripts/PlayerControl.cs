using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl: MonoBehaviour
{
    Rigidbody rb;
    public float forceMultiplier = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * forceMultiplier;
        float y = Input.GetAxis("Vertical") * forceMultiplier;

        rb.AddForce(Vector3.forward * y);
        rb.AddForce(Vector3.right * x);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Obstacle"))
        {
            Destroy(this.gameObject);


        }
    }
}

