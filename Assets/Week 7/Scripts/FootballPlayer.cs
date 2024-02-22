using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballPlayer : MonoBehaviour
{
    SpriteRenderer sr;
    public Color selectedColor;
    public Color unselectedColor;
    Rigidbody2D rb;
    public float speed = 500;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        Selected(false);
    }

    private void OnMouseDown()
    {
        Controller.SetSelectedPlayer(this);
    }

    public void Selected(bool isSelected)
    {
        if (isSelected)
        {
            sr.color = selectedColor;
        }
        else
        {
            sr.color = unselectedColor;
        }
    }

    public void Move(Vector2 direction)
    {
        rb.AddForce(direction * speed);
    }
}
