using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptUI : MonoBehaviour
{

    // Start is called before the first frame update
    public void kluarGame(){
        Application.Quit();
    }
    public void pindah(){
        SceneManager.LoadScene("1");
    }
    public void home(){
        SceneManager.LoadScene("0");
        Debug.Log("Home");
    }
    public void info()
    {
        SceneManager.LoadScene("25");
    }

    public void vrMode()
    {
        Music.Instance.hapus();
        SceneManager.LoadScene("vr_on");
    }
}
