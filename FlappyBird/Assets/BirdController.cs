using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);   
    }

    // Update is called once per frame
    void Update()
    {

    }
}
