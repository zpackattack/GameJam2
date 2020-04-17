using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    AudioListener AudioListener;
    public AudioMixer SFXMixer;
    public void MusicToggle()
    {
        AudioListener.pause = !AudioListener.pause;
    }

    public void SetVolume(float volume)
    {
        Debug.Log(volume);
        audioMixer.SetFloat("MusicVol", volume);
    }
    public void SetSFXVolume(float volumeS)
    {
        Debug.Log(volumeS);
        SFXMixer.SetFloat("SFXVol", volumeS);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(3);
    }
    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    public void Options()
    {
        SceneManager.LoadScene(2);
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene(1);
    }
}
