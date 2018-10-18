using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGO : MonoBehaviour {

    public float speed;


	// Use this for initialization
	void Start ()
    {
        //speed = Random.Range(1.0f, 5.0f);
	}
	
	// Update is called once per frame
	void FixedUpdate ()

    {
        transform.position += new Vector3(0.0f, 0.0f, -(speed * Time.fixedDeltaTime) )  ;
	}
}
