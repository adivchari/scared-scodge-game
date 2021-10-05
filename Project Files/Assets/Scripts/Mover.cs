using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mover : MonoBehaviour
{
    Vector2 targetPos;
    public AudioSource scodge;
    [SerializeField] AudioClip popsound;
    [SerializeField] public AudioClip damageSound;
    [SerializeField] float yDisplacement=5f;
    [SerializeField] float speed=75f;
    [SerializeField] public int health=3; 
    [SerializeField] ParticleSystem PlayerMove;
    [SerializeField] Text HP;
    [SerializeField] GameObject gameOver;

    void Start()
    {
        scodge=GetComponent<AudioSource>();
    }
    
    void Update()
    {
        HP.text = health.ToString();
        targetPosition();
        if (health <= 0) 
            deathSequence();
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        
    }
    
    void targetPosition()
    {
    
        if(Input.GetKeyDown(KeyCode.W) && transform.position.y < yDisplacement)
        {
            targetPos = new Vector2 (transform.position.x, transform.position.y+yDisplacement);
            Instantiate(PlayerMove, transform.position, Quaternion.identity);
            scodge.PlayOneShot(popsound);
            
        }
        else if(Input.GetKeyDown(KeyCode.S) && transform.position.y > -yDisplacement)
        {
            targetPos = new Vector2 (transform.position.x, transform.position.y-yDisplacement);
            Instantiate(PlayerMove, transform.position, Quaternion.identity);
            scodge.PlayOneShot(popsound);
            
        }
        
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);       //moves pcject from pos tp targetPos at speed
   }

   void deathSequence()
   {
        gameOver.SetActive(true);
        Destroy(gameObject);
   }
}
