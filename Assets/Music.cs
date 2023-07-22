using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public static Music Instance {get; set;}
    public GameObject playerRig;

    //[HideInInspector]
    public AudioSource asMusic;
    public Slider sVolumeMusic;
    //[HideInInspector]

    //public Sprite[] spriteMute;
    public Button buttonMute;
    

    private void Awake()
    {
        asMusic = transform.GetChild(0).GetComponent<AudioSource>();

        DontDestroyOnLoad(this);

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonMusicMute()
    {
        if(asMusic.mute == false)
        {
            asMusic.mute = true;
          //  buttonMute.image.sprite = spriteMute[0];
            
        }
        else
        {
            asMusic.mute = false;
          //  buttonMute.image.sprite = spriteMute[1];
        }
    }
    public void hapus()
    {
        Destroy(playerRig);
    }
     

}
