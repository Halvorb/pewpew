using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSADControls : MonoBehaviour
{

    public float speed = 15f;
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        
        transform.Translate(horizontal * Time.deltaTime * speed, 0, vertical * Time.deltaTime * speed);
        


    }
}
