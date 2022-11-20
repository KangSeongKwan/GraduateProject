using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSound : MonoBehaviour
{
    public AudioClip audioButton1;
    public AudioClip audioButton2;
    public AudioClip audioButton3;
    public AudioClip audioButton4;
    public AudioClip audioButton5;
    public AudioClip audioBookOpen1;
    public AudioClip audioBookOpen2;
    public AudioClip audioBookOpen3;
    public AudioClip audioBookClose1;
    public AudioClip audioBookClose2;
    public AudioClip audioBookClose3;
    AudioSource audioSource;
    public void SFXPlay(string sfxName)
    {
        this.audioSource = GetComponent<AudioSource>();

        switch (sfxName)
        {
            case "audioButton1":
                audioSource.clip = audioButton1;
                break;

            case "audioButton2":
                audioSource.clip = audioButton2;
                break;

            case "audioButton3":
                audioSource.clip = audioButton3;
                break;

            case "audioButton4":
                audioSource.clip = audioButton4;
                break;

            case "audioButton5":
                audioSource.clip = audioButton5;
                break;
            case "audioBookOpen1":
                audioSource.clip = audioBookOpen1;
                break;
            case "audioBookOpen2":
                audioSource.clip = audioBookOpen2;
                break;
            case "audioBookOpen3":
                audioSource.clip = audioBookOpen3;
                break;
            case "audioBookClose1":
                audioSource.clip = audioBookClose1;
                break;
            case "audioBookClose2":
                audioSource.clip = audioBookClose2;
                break;
            case "audioBookClose3":
                audioSource.clip = audioBookClose3;
                break;
        }
        audioSource.Play();
    }
}
