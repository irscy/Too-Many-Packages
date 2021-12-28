using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class byebyerocc : MonoBehaviour
{
    [SerializeField] Color32 ded = new Color32 (255, 255, 255, 0);
    SpriteRenderer spriteRenderer;
    
    

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "stabbie")
        {
            spriteRenderer.color = ded;
        }
    }
}
