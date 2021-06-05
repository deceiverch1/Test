using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlatform : MonoBehaviour {

    public GameObject enemyPlatform;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.CompareTag("Ball"))
        {
            Destroy(enemyPlatform);
        }
    }
}
