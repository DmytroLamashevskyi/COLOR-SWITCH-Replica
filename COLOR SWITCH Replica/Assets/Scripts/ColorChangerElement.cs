using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
public class ColorChangerElement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
     

    internal void ColorChanged()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
}
