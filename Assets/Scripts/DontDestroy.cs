using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    
    void Start()
    {
        switch (gameObject.tag)
        {
            case "Click": 
                if (GameObject.FindGameObjectsWithTag("Click").Length == 1)
                    DontDestroyOnLoad(gameObject);
                else Destroy(gameObject);
                break;

            case "Audio": 
                if (GameObject.FindGameObjectsWithTag("Audio").Length == 1)
                    DontDestroyOnLoad(gameObject);
                else Destroy(gameObject);
                break;

        }
            
        
    }

    
}
