using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private float Speed;

      
    void Update()
    {
        transform.Rotate(0f, 0f, Speed * Time.deltaTime);
    }
}
