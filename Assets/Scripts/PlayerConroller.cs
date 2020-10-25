/*
    File Name: PlayerConroller.cs
    Student Name: Han Zhan
    Student ID: 101141379
    Date last Modified: 2020/10/25
    Program description: Control player movement and get player HP
    Revision History:
    2020/10/23 Add player movement and player movement range.
    2020/10/24 Added player HP and damage sound effects.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerConroller : MonoBehaviour
{
    [SerializeField]
    float speed = 5;

    public float XBoundary;
    public float YBoundary;
    public int health;
    private Vector3 m_touchesEnded;
    public Text HealthNumber;

    [SerializeField]
    Rigidbody2D rigidBody;

    void Start()
    {
        m_touchesEnded = new Vector3();
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
        //Vector2 movementVector = new Vector2(Input.GetAxis("Horizontal"),0.0f);
        //movementVector *= speed;
        //transform.Translate(movementVector* Time.deltaTime);

        // touch input support
        foreach (var touch in Input.touches)
        {
            var worldTouch = Camera.main.ScreenToWorldPoint(touch.position);

            if (worldTouch.x > 0.0f)
            {
                // direction is positive
                transform.Translate(new Vector2(speed, 0.0f) * Time.deltaTime);
            }

            if (worldTouch.x < 0.0f)
            {
                // direction is negative
                transform.Translate(new Vector2(-speed, 0.0f) * Time.deltaTime);
            }

            m_touchesEnded = worldTouch;

            HealthNumber.text = health.ToString();

            if(health <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }

            Play_CheckBounds();
        }
    }

    private void Play_CheckBounds()
    {
        if(transform.position.x >= XBoundary)
        {
            transform.position = new Vector3(XBoundary, transform.position.y, 0.0f);
        }

        if (transform.position.x <= -XBoundary)
        {
            transform.position = new Vector3(-XBoundary, transform.position.y, 0.0f);
        }

        if (transform.position.y < -YBoundary)
        {
            transform.position = new Vector3(transform.position.x, -YBoundary, 0.0f);
        }

    }

    private void OnTriggerEnter2D(Collider2D PlayerCld)
    {
        health--;
        GetComponent<AudioSource>().Play();
        Debug.Log("hit");
    }
}
