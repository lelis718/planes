using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SoundController : MonoBehaviour, IPointerDownHandler
{
    public Sprite soundImageOn;
    public Sprite soundImageOff;
        
    Image soundImage;
    bool soundOn ;

    private void Awake()
    {
        soundImage = GetComponent<Image>();
    }
    private void Start()
    {
        soundOn = true;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        soundOn = !soundOn;
        if (soundOn)
        {
            soundImage.sprite = soundImageOn;
            AudioListener.pause = false;
        } else
        {
            soundImage.sprite = soundImageOff;
            AudioListener.pause = true;
        }
        
    }
}

