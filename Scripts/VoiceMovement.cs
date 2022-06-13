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
    public Piece pieza{get; private set; }

    public string firstlevel;
    public string secondlevel;
    public float velocidad;
    public GameObject optionsScreen;
    public GameObject mapa1;
    public GameObject mapa2;

    void Start()
    {
        
        actions.Add("Play Now", Play);
        actions.Add("Test", Test);
        actions.Add("Credits", Options);
        actions.Add("Player Two", Options);
        actions.Add("Back", CloseOptions);


        actions.Add("Slow", Speed1);
        actions.Add("Medium", Speed2);
        actions.Add("Fast", speed3);
        actions.Add("Map one", Map1);
        actions.Add("Map two", Map2);
        actions.Add("Exit", CloseOptions);
        
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

    public void Speed1()
    {

        this.pieza = pieza;
        pieza.velocidad=1f;   
        pieza.Update();
        Debug.Log("Speed up");
    }

    public void Speed2()
    {
        this.pieza = pieza;
        pieza.velocidad=5f;   
        pieza.Update();
        Debug.Log("Speed up");
    }

    public void speed3()
    {
        this.pieza.velocidad=10f;     
        Debug.Log("Speed up");
        
    }

    public void Map1()
    {
        mapa2.SetActive(false);
        mapa1.SetActive(true);
        
    }

    public void Map2()
    {
        mapa1.SetActive(false);
        mapa2.SetActive(true);   
        
    }

    public void Map3()
    {
        Debug.Log("Map3");  
        
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
