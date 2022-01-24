using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private int JumpForce;

    private ElementId CurentId;
    private Rigidbody2D rigidbody;
    private SpriteRenderer sprite;



    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        SetRandomColor();
    }

    private void SetRandomColor()
    {
        Debug.Log("Set new color");
        Array values = Enum.GetValues(typeof(ElementId));
        System.Random random = new System.Random();
        CurentId = (ElementId)values.GetValue(random.Next(values.Length));
        sprite.color = InitColors.Instance.GetColor(CurentId);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rigidbody.velocity = Vector2.up * JumpForce;
        } 

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); 

            Debug.Log("Touch Position : " + touch.position);
            rigidbody.velocity = Vector2.up * JumpForce;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var circleElement = collision.gameObject.GetComponent<CircleElement>();
        if (circleElement != null)
        {
            if (circleElement.Id != this.CurentId)
            {
                Debug.Log("Game Over");
            } 
        }

        var colorChanger = collision.gameObject.GetComponent<ColorChangerElement>();
        if (colorChanger  != null)
        { 
            SetRandomColor();
            colorChanger.ColorChanged();
        }

    }
}
