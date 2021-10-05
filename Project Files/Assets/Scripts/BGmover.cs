using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGmover : MonoBehaviour
{
    
    [SerializeField] float speed;
    [SerializeField] float StartX;
    
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if ( transform.position.x < -37.49)
        {
            Vector2 pos = new Vector2( StartX, transform.position.y);
            transform.position = pos;
        }
            
    }

}
