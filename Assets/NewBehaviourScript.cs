using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bit : MonoBehaviour
{
    SpriteRenderer spriteRenderer; // Variabele om de sprite op te slaan

    public bool state = false;

    public TextAlignment output;

    void Start()
    {
        // Haal de SpriteRenderer op en sla het op in de variabele
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.black;
    }

    private void OnMouseUp()
    {
        if (state)
        {
            state = false;

            //output.text = "0";

            spriteRenderer.color = Color.black;
        }
        else
        {
            state = true;

            //output.text="1";

            spriteRenderer.color = Color.red;
        }
    }
}

