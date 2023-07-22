using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRig : MonoBehaviour
{
    public static PlayerRig Instance;
   
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    
    DontDestroyOnLoad(this);
    /*   
    DontDestroyOnLoad(gameObject);
        for (int i = 0; i< Object.FindObjectsOfType<PlayerRig>().Length; i++)
        {
            if (Object.FindObjectsOfType<PlayerRig>()[i] != this)
            {
                if(Object.FindObjectsOfType<PlayerRig>()[i].name == gameObject.name)
                {
                    Destroy(gameObject);
                }
                
            }
        }
       
    }
*/
    

    }
}
