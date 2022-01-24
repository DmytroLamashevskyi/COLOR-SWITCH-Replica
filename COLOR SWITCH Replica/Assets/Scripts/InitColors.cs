using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitColors : MonoBehaviour
{
    public static InitColors Instance;

    public Color SectorOne = Color.blue;
    public Color SectorTwo = Color.red;
    public Color SectorThree = Color.green;
    public Color SectorFour = Color.yellow;
     

    public void Awake()
    {
        Instance = this;
    }



    public Color GetColor(ElementId elementId)
    {
        switch (elementId)
        {
            case ElementId.Blue: return SectorOne;
            case ElementId.Red: return SectorTwo;
            case ElementId.Green: return SectorThree;
            case ElementId.Yellow: return SectorFour;
            default: return Color.white;
        }  
    }

}
