using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonColorChanges : MonoBehaviour
{

    [SerializeField] private ColorChangeLogic colorLogic = null;

    private bool _isRed = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(_isRed == true)
        {
            colorLogic.BlueColor();
        }
        else
        {
            colorLogic.RedColor();
        }


    }
}
