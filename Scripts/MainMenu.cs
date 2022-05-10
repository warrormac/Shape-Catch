using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public VoiceMovement voice { get; private set; }
    public faceDetector face{get; private set; }
     public WebCamTexture webcamTexture;
    public GameObject optionsScreen;




    public void StartGame()
    {

        this.voice = voice;
        voice.Play();
    }

    public void Test()
    {

        this.voice = voice;
        voice.Test(); 
    }



    public void OpenOptions()
    {
        //optionsScreen.SetActive(true);
        this.voice = voice;
        voice.Options();
    }

    public void CloseOptions()
    {
        //optionsScreen.SetActive(false);
        this.voice = voice;
        voice.CloseOptions();
    }
  
    public void QuitGame()
    {
        
        this.voice = voice;
        voice.Quit();
        
    }
}
