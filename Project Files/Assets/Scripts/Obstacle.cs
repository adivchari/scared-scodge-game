using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] int damage = 1;
    [SerializeField] float speed=5f;
    [SerializeField] ParticleSystem PlayerHit;
    

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); 
        if ( transform.position.x < -19.2)
            Destroy(gameObject);
    }

   void OnTriggerEnter2D(Collider2D other) 
   {
       //damage player, play damage sound from mover class, destroy obstacle
       
            other.GetComponent<Mover>().health -= damage;
            Instantiate(PlayerHit, transform.position, Quaternion.identity);
            Destroy(gameObject);
   }
}

       
        
        
    
    

