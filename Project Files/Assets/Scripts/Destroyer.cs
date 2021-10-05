using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] float lifetime = 5f;
    void Update()
    {
        Destroy(gameObject, lifetime);
    }
}
