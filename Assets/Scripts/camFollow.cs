using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody playerRB;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerRB.transform.position.x, playerRB.transform.position.y + 5f, playerRB.transform.position.z - 10.5f);

    }
}
