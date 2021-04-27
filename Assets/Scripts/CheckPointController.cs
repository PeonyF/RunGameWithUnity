using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    public Sprite flagClosed;
    public Sprite flagOpen;

    private SpriteRenderer spriteRenderer;

    private bool checkPointActive;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
 
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            spriteRenderer.sprite = flagOpen;
            checkPointActive = true;
        }
    }
}
