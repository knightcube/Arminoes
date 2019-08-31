using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoSpawnerScript : MonoBehaviour
{
    public float distance = 0.5f; 
    public GameObject myDomino;
    public GameObject firstDomino;
    public Vector3 lastPlottedPosition;
    public float interval;
    private float currentDistance;
    private Vector3 delta;
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        delta = transform.position - lastPlottedPosition;
        currentDistance = delta.magnitude;

        interval += 0.2f;
          myDomino.GetComponent<Rigidbody>().AddForce(Vector3.down * Time.deltaTime * 1000);
        if(count<100){
            Plot();
            count++;
        }
        
    }

    void Plot()
    {
        lastPlottedPosition = transform.position;
        transform.position = new Vector3(0,0.53f,interval);
        Instantiate(myDomino, transform.position, transform.rotation);
        
    }
    
}
