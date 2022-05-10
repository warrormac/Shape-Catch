using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;
using UnityEngine.SceneManagement;

public class VoiceMovement : MonoBehaviour
{

    private KeywordRecognizer KeywordRecognizer;
    public string game;
    public faceDetector face{get; private set; }
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

    public string firstlevel;
    public string secondlevel;
    public GameObject optionsScreen;

    void Start()
    {
        
        actions.Add("Play Now", Play);
        actions.Add("Test", Test);
        actions.Add("Credits", Options);
        actions.Add("Back", CloseOptions);
        actions.Add("Quit", Quit);

        KeywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        KeywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        KeywordRecognizer.Start();
    }



    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }



    public void Home()
    {
        
        SceneManager.LoadScene(game);  
        
    }
    public void Play()
    {
        SceneManager.LoadScene(firstlevel);    
        
    }

        public void Test()
    {
        SceneManager.LoadScene(secondlevel);    
        
    }

    public void Options()
    {
        optionsScreen.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsScreen.SetActive(false);
        //SceneManager.LoadScene(game);  
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("quitting");
    }
}
