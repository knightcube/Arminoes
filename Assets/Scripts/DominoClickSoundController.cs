using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoClickSoundController : MonoBehaviour
{
    public AudioClip dominoClickSound; 
    public AudioClip dominoFloorSound; 
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
         audioSource = GetComponent<AudioSource>();
         audioSource.playOnAwake = false;
         audioSource.clip = dominoClickSound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision colliderObject)  //Plays Sound Whenever collision detected
     {
        //   GetComponent<AudioSource> ().Play ();
        //  Debug.Log(colliderObject.gameObject.tag);
         audioSource.volume = colliderObject.relativeVelocity.magnitude;
        
         if(colliderObject.gameObject.tag == "Domino"){
             audioSource.clip = dominoClickSound;
             // Collision of Dominos
             audioSource.Play ();
         }else{
             audioSource.clip = dominoFloorSound;
             // Collision of Domino with floor
             audioSource.Play();
         }

     }
}
