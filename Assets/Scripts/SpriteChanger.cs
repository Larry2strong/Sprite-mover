﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    //Declare a variable
    private SpriteRenderer spriteRenderer;
    public Color color = Color.green;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        if (spriteRenderer !=null)
        {
            spriteRenderer.color = Color.green;
        }
      else
        {
            Debug.LogError("No Sprite Render Attached");
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (spriteRenderer != null)
        {
            spriteRenderer.color = color;
        }
        else
        {
            Debug.LogError("No Sprite Render Attached");
        }
    }
}
