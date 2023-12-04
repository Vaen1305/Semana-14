using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoControl : MonoBehaviour
{
    public float speedY;
    private Rigidbody2D _compRigidbody;
    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(0, speedY);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Muros") == true)
        {
            Destroy(this.gameObject);
        }
        else if (collision.CompareTag("Enemy") == true)
        {
            Destroy(this.gameObject);
        }
    }
}
