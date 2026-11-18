using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventOnTrigger : MonoBehaviour
{
    [Tooltip("The colliding object that we want to trigger these events with needs to use a tag of the same name as typed in this variable")]
    public string tagToActivate = "Player";

    public ParticleSystem ps;

    private void Awake()
    {
        if ((GetComponent<Collider>() == null) && (GetComponent<Collider2D>() == null))
        {
            Debug.Log($"{gameObject} is missing a collider");
        }
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(tagToActivate))
        {
            ps.Play();
            Destroy(GetComponent<CircleCollider2D>());
            Destroy(GetComponent<SpriteRenderer>());
        }
    }
    
}
