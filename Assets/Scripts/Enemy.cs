using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Rigidbody rigidbody;


    public Vector3 direction;
    public float baseSpeed;
    public float coefficientSpeed; 

    // Use this for initialization
    void Start () {

        
    }
	
	// Update is called once per frame
	void Update () {

        rigidbody.velocity = direction * baseSpeed;

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            direction.x = -direction.x;
        }

    }
}
