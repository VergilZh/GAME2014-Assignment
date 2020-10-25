/*
    File Name: Score.cs
    Student Name: Han Zhan
    Student ID: 101141379
    Date last Modified: 2020/10/25
    Program description: Calculate the score obtained by the player.
    Revision History: 
    2020/10/24 Change game time to int, output game time as player score.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    float Ftimer = 0.0f;
    int Itimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ftimer += Time.deltaTime;
        Itimer = (int)Ftimer;
        scoreText.text =Itimer.ToString();
    }
}
