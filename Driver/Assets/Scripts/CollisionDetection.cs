using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] Color32 colorGreen = new Color32(53,212,29,255);
    [SerializeField] Color32 colorYellow = new Color32(236,206,13,255);
    [SerializeField] Color32 colorRed = new Color32(241,35,35,255);
    [SerializeField] Color32 colorOrange = new Color32(255,117,35,255);
    
    SpriteRenderer spriteRenderer;
    int score = 0;
    
    public AudioSource audioSource;
    public AudioClip[] Sesler;
    public TextMeshProUGUI scoreText;
    
    
    
    
    
    
    
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        
        
        
    }
    public void Addcoin()
    {
        score++;
        scoreText.text = "Score: "+score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "gold")
        {
            audioSource.clip = Sesler[0];
            audioSource.Play();
            Addcoin();
            if (score % 2 == 0)
            {
                spriteRenderer.color = colorOrange;
            }
            else if(score % 3 == 0)
            {
                spriteRenderer.color = colorRed;
            }
            else if(score % 5 == 0)
            {
                spriteRenderer.color = colorGreen;
            }
            else
            {
                spriteRenderer.color = colorYellow;
            }
            
            
            
            Destroy(col.gameObject);
            
            
        }

        else if (col.gameObject.CompareTag("finish"))
        {
           audioSource.clip = Sesler[1];    
           audioSource.Play();
              
           
       
           
            
           
           Debug.Log("You Win");
           
        }
       
    }
    
    
}
