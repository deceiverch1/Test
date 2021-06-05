using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ball : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler {

        [SerializeField] public Rigidbody rigidbody;
        [SerializeField] float speed;
        [SerializeField] public Vector3 direction;
        [SerializeField] public GameObject ball;
  

    public bool ballIsDestroy = false;

    public void OnBeginDrag(PointerEventData eventData)
    {

        Debug.Log("On Begin");
    }

    public void OnDrag(PointerEventData eventData)
    {

        Debug.Log("On Drag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        Debug.Log("On End Drag");
    }

    public void OnPointerDown(PointerEventData eventData)
    {

        Debug.Log("Press");
    }
        

        
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {



        rigidbody.velocity = direction * speed;

      

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            direction.x = -direction.x;
        }

        if (col.gameObject.CompareTag("Wall2"))
        {
            direction.z = -direction.z;
        }

        if(col.gameObject.CompareTag("EnemyPlatform") || col.gameObject.CompareTag("Player"))
        {
            Destroy(ball);
            
            ballIsDestroy = true;
        }

    }
    
   


    

}
