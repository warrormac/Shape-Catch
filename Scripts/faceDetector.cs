using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenCvSharp;


public class faceDetector : MonoBehaviour
{
    WebCamTexture _webCamTexture;

    // Start is called before the first frame update
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        
        _webCamTexture = new WebCamTexture(devices[0].name);
        _webCamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.mainTexture = _webCamTexture;
    }
}