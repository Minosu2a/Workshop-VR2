using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("T key Pressed");
        }

    }
}
