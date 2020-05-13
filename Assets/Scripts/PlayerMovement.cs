using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour  {

    public int playerSpeed;
    //public Transform camera;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButton("Fire1"))
        if (Input.GetMouseButton(0))
        {
        transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
   
    }
    }
}
