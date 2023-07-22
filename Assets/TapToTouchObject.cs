using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class TapToTouchObject : MonoBehaviour
{
    // Start is called before the first frame update

    
    void Start()
    {
         
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                if (hit.collider.CompareTag("GantiScene"))
                {
                    Debug.Log("Ganti Scene" + hit.collider.gameObject.name);
                    SceneManager.LoadSceneAsync(hit.collider.gameObject.name);
                }
                if (hit.collider.CompareTag("VRbutton"))
                {
                    //
                    Debug.Log("VRbutton");
                }
            }
        }
    }

   

}