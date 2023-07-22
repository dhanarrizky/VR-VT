using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuOne : MonoBehaviour
{
   // public AudioSource asM;
    
    public Sprite[] spriteMute;
    public Button buttonMute;
    public Slider sliderVolume;
    // Start is called before the first frame update
    //asMusic = transform.GetChild(0).GetComponent<AudioSource>();
    void Start()
    {  
        sliderVolume.value = Music.Instance.asMusic.volume;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void volumM()
    {

       Music.Instance.asMusic.volume = sliderVolume.value;
        if (sliderVolume.value == 0)
        {
            Music.Instance.asMusic.mute = true;
            buttonMute.image.sprite = spriteMute[0];
        } else
        {
            Music.Instance.asMusic.mute = false;
            buttonMute.image.sprite = spriteMute[1];
        }
       
    }
    
    public void musicMute()
    {
        
        Music.Instance.ButtonMusicMute();
        if(Music.Instance.asMusic.mute == true)
        {
            buttonMute.image.sprite = spriteMute[0];
        } 
        if(Music.Instance.asMusic.mute == false )
        {
            buttonMute.image.sprite = spriteMute[1];
        }
        
    }

    

    
}     