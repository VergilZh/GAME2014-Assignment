/*
    File Name: EnemyAttack.cs
    Student Name: Han Zhan
    Student ID: 101141379
    Date last Modified: 2020/10/25
    Program description: Control obstacle damage, movement and range.
    Revision History:
    2020/10/23 Add obstacle rotation and movement range.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAttack : MonoBehaviour
{
    public float YSpeed;
    private float YTopBoundary;
    public float YDownBoundary;
    public float direction;

    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = new Vector3(Random.Range(0, 10), transform.localPosition.y, transform.localPosition.z);
        YTopBoundary = Random.Range(0, 4);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,3600*Time.deltaTime);
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.localPosition += new Vector3(0.0f, YSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        if(transform.localPosition.y >= YTopBoundary)
        {
            direction = -1.0f;
        }

        if(transform.localPosition.y <= YDownBoundary)
        {
            direction = 1.0f;
            YTopBoundary = Random.Range(0, 4);
        }
    }

    //private void OnTriggerEnter2D(Collider2D PlayerCld)
    //{
    //    SceneManager.LoadScene("GameOver");
    //    Debug.Log("hit");
    //}


}
