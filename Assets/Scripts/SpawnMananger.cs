using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMananger : MonoBehaviour {

    public GameObject[] enemyPlatform;
    public GameObject ball;
    public int platrofmCount = 3;
   public bool ballIsDestroy = false;
    // Use this for initialization


    void Start()
    {
    
        Instantiate(enemyPlatform[0]);
        Instantiate(enemyPlatform[1]);
        Instantiate(enemyPlatform[2]);
        Instantiate(ball);

    }
	
    

	// Update is called once per frame
	void Update () {

       if(platrofmCount == 0)
        {
            Instantiate(enemyPlatform[0]);
            Instantiate(enemyPlatform[1]);
            Instantiate(enemyPlatform[2]);
        }

		if( ballIsDestroy == true)
        {
            Instantiate(ball);
        }
	}

   

}
