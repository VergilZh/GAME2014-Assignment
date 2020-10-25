/*
    File Name: BossBulletSwap.cs
    Student Name: Han Zhan
    Student ID: 101141379
    Date last Modified: 2020/10/25
    Program description: Repeatedly spawn bullets.
    Revision History:
    2020/10/23 Add bullet generation.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletSwap : MonoBehaviour
{
    public GameObject target;
    public GameObject playerfab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 2.0f, Random.Range(2.0f, 5.0f));
    }

    void Fire()
    {
        Instantiate(playerfab, target.transform.position,new Quaternion());
        Debug.Log("fire now");
    }
}
