using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishController : MonoBehaviour {

    [SerializeField]
    private float jumpForce = 50f;
    private float GoRight = 10f;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetButtonDown("Fire1"))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.right * GoRight);
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
}
