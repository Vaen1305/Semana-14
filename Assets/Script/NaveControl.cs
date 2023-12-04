using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveControl : MonoBehaviour
{
    public float speedY;
    private float directionY = -1;
    private Rigidbody2D _compRigidbody;
    private Animator _compAnimator;
    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
        _compAnimator = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(0, speedY*directionY);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rayo") == true)
        {
            Destroy(this.gameObject, 1);
            _compAnimator.SetTrigger("New Trigger");

        }
        if (collision.CompareTag("Muros") == true)
        {
            Destroy(this.gameObject);
        }
    }

}

