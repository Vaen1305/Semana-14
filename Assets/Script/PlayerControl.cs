using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speedX;
    public float speedY;
    public float directionX;
    public float directionY;
    public GameObject bulletPrefab;
    private SpriteRenderer _compSpriteRenderer;
    public GameObject sonidodisparo;
    void Awake()
    {
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D) == true)
        {
            directionX = 1;
            _compSpriteRenderer.flipX = true;
        }
        else if (Input.GetKey(KeyCode.A) == true)
        {
            directionX = -1;
            _compSpriteRenderer.flipX = false;
        }
        else
        {
            directionX = 0;
        }
        if (Input.GetKey(KeyCode.W) == true)
        {
            directionY = 1;
        }
        else if (Input.GetKey(KeyCode.S) == true)
        {
            directionY = -1;
        }
        else
        {
            directionY = 0;
        }
        transform.position = new Vector2(transform.position.x + speedX * directionX * Time.deltaTime, transform.position.y + speedY * directionY * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            Instantiate(sonidodisparo);
        }
    }
}
