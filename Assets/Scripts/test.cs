using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    Vector3 FP, LP;
    float DragDistance = 20f;
    void Update()
    {

        if (Input.GetMouseButtonDown(0))                                       //Swipe using Buttonup/ButtonDown
        {
            FP = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            LP = Input.mousePosition;
        }

        if (Mathf.Abs(LP.x - FP.x) > DragDistance || Mathf.Abs(LP.y - FP.y) > DragDistance) //Swipe happened;
        {
            if (Mathf.Abs(LP.x - FP.x) > Mathf.Abs(LP.y - FP.y))
            {   //If the horizontal movement is greater than the vertical movement...
                if ((LP.x > FP.x))  //If the movement was to the right)
                {   //Right swipe

                }
                else
                {   //Left swipe

                }
            }
            else
            {   //the vertical movement is greater than the horizontal movement
                if (LP.y > FP.y)  //If the movement was up
                {   //Up swipe

                }
                else
                {   //Down swipe

                }
            }
        }
        else
        {
            //Tap Functionality

        }


    }

}
