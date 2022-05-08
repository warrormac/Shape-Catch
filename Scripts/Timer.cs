using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public faceDetector face{get; private set; }
    public WebCamTexture webcamTexture;
    public string game;

    public void Start()
{
    //Start the coroutine we define below named ChangeAfter2SecondsCoroutine().
    
    StartCoroutine(ChangeAfter2SecondsCoroutine());
}

public IEnumerator ChangeAfter2SecondsCoroutine()
{
    //Print the time of when the function is first called.
    Debug.Log("Started Coroutine at timestamp : " + Time.time);

    //yield on a new YieldInstruction that waits for 2 seconds.
    yield return new WaitForSeconds(2);

    //After we have waited 2 seconds print the time again.
    Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    //And load the scene
    Application.LoadLevel(game);  //<-- This is the correct name of the scene
}


    void Loading()
    {
       SceneManager.LoadScene(game);  
    }


}
