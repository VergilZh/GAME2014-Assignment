/*
    File Name: BossBullet.cs
    Student Name: Han Zhan
    Student ID: 101141379
    Date last Modified: 2020/10/25
    Program description: Control the trajectory and collision of boss bullet.
    Revision History:
    2020/10/23 Create and add bullet pictures and set bullet trajectory.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossBullet : MonoBehaviour
{
    public float MinPower = 8;
    public float MaxPower = 15;
    public float Angle;
    public float Gravity;
    private Vector3 MoveSpeed;
    private Vector3 GritySpeed = Vector3.zero;
    private float dTime;
    private Vector3 currentAngle;


    void Start()
    {
        MoveSpeed = Quaternion.Euler(new Vector3(0, 0, Angle)) * Vector3.right * Random.Range(MinPower,MaxPower);
        currentAngle = Vector3.zero;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GritySpeed.y = Gravity * (dTime += Time.fixedDeltaTime);
        transform.position += (MoveSpeed + GritySpeed) * Time.fixedDeltaTime;
        currentAngle.z = Mathf.Atan((MoveSpeed.y + GritySpeed.y) / MoveSpeed.x) * Mathf.Rad2Deg;
        transform.eulerAngles = currentAngle;
    }

    //private void OnTriggerEnter2D(Collider2D PlayerCld)
    //{
    //    SceneManager.LoadScene("GameOver");
    //    Debug.Log("hit");
    //}

}
