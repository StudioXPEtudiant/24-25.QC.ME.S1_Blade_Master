using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMousePosition : MonoBehaviour
{
    //the object to move
    public Transform objectToMove;
    
     void Update()
     {
         Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         //Vector3 mouse = Input.mousePosition;
         mouse.z = 0;
         objectToMove.position = mouse;
     }
}
