using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CircleElement : MonoBehaviour
{
    public ElementId Id;

    private SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = InitColors.Instance.GetColor(Id);
    } 
}

public enum ElementId
{
    Blue, Red, Yellow, Green
}