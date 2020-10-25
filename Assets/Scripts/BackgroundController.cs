/*
    File Name: BackgroundConroller.cs
    Student Name: Han Zhan
    Student ID: 101141379
    Date last Modified: 2020/10/25
    Program description: Control background movement.
    Revision History:
    2020/10/23 Add background move and refresh background.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float XSpeed;
    public float XBoundary;
    // Update is called once per frame
    void Update()
    {
        BG_Move();
        BG_CheckBounds();
    }

    private void BG_Reset()
    {
        transform.position = new Vector3(XBoundary, 0.0f);
    }

    private void BG_Move()
    {
        transform.position -= new Vector3(XSpeed, 0.0f) * Time.deltaTime;
    }

    private void BG_CheckBounds()
    {
        if(transform.position.x <= -XBoundary)
        {
            BG_Reset();
        }
    }
}
