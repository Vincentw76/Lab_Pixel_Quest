using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteColorChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color color1 = Color.blue;
    public Color color2 = Color.red;
    public Color color3 = Color.green;

    // Start is called before the first frame update
    void Start()
    {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spriteRenderer.color = color1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spriteRenderer.color = color2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spriteRenderer.color = color3;
        }
    }
}
