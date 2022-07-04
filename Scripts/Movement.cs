using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;
    public float lastY = 0;
    public faceDetector faceDect;


    // Start is called before the first frame update
    void Start()
    {
        faceDect = (faceDetector)FindObjectOfType(typeof(faceDetector));
        Vector3 start = new Vector3 (0,0,0);
        transform.position = start;
        lastY=0;//(faceDect.faceY);
    }

    // Update is called once per frame
    void Update()
    {
        float diferencia = (lastY - faceDect.faceY);
        if (!(diferencia >= -20.57 && diferencia<=20.33))
        {
            diferencia=0.0f;
        }
        Vector3 moveY=new Vector3(diferencia,0,0);
        //transform.Translate(moveY);


        transform.position+=moveY*Time.deltaTime;
        lastY=faceDect.faceY;

        /*if (transform.position.x >= -4.57)
        {
            diferencia=-4.57f;
            transform.position=new Vector3(diferencia,0,0);
        }*/

        Debug.Log(transform.position.x);

        //float step = speed * Time.deltaTime;
        //float norm = Mathf.Clamp(faceDect.faceY - lastY, -1, 1);
        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + norm, transform.position.z), step);

        //transform.position = new Vector3(transform.position.x+norm, transform.position.y , transform.position.z);
    }
}
