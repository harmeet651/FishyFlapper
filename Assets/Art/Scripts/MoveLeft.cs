using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {

    [SerializeField]
    private float speed = 2.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Time.deltaTime * speed * Vector3.left;
        if(transform.position.x <= -15)
        {
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }
	}
}
