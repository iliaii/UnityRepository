using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody playerRB;
    public float horizontal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        playerRB.AddForce(Vector3.forward, ForceMode.Impulse);

       
        playerRB.AddForce(Vector3.right*horizontal, ForceMode.Impulse);
       
    }
}
