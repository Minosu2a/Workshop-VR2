using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeLogic : MonoBehaviour
{

    [SerializeField] private Light _spotlight = null;


    [SerializeField] private GameObject _blueObj1 = null;
    [SerializeField] private GameObject _redObj1 = null;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void RedColor()
    {
        _spotlight.color = Color.red;
        _redObj1.SetActive(true);
        _blueObj1.SetActive(false);

    }

    public void BlueColor()
    {
        _spotlight.color = Color.blue;
        _blueObj1.SetActive(true);
        _redObj1.SetActive(false);

    }
}
