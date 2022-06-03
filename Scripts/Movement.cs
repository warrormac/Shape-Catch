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
        lastY=0;//(faceDect.faceY);
    }

    // Update is called once per frame
    void Update()
    {
        float diferencia = (lastY - faceDect.faceY);
        Vector3 moveY=new Vector3(diferencia,0,0);
        //transform.Translate(moveY);

        transform.position+=moveY*Time.deltaTime;
        lastY=faceDect.faceY;
        //float step = speed * Time.deltaTime;
        //float norm = Mathf.Clamp(faceDect.faceY - lastY, -1, 1);
        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + norm, transform.position.z), step);

        //transform.position = new Vector3(transform.position.x+norm, transform.position.y , transform.position.z);
    }
}
