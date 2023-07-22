using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartVT : MonoBehaviour
{
    public string firstScene = "";
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadSceneAsync(firstScene);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
