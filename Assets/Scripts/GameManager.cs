using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject moreHelpWindows;
    
    // Start is called before the first frame update
    void Start()
    {
        moreHelpWindows.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateMoreHelpWindows(){
        moreHelpWindows.SetActive(true);
    }
}
