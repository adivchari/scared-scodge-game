using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
   
    [SerializeField] public int score=0;
    [SerializeField] Text yourScore;
    
    void OnTriggerEnter2D(Collider2D other)         //not checking what is colliding with the score counter, incrementing score on each collison
        {                                       
            score++;
            yourScore.text = score.ToString();
        }
    
}
