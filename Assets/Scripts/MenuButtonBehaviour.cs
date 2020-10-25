/*
    File Name: MenuButtonBehaviour.cs
    Student Name: Han Zhan
    Student ID: 101141379
    Date last Modified: 2020/10/25
    Program description: Change to the next scene.
    Revision History:
    2020/10/4 Control scene switching
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMenuButtonPressed()
    {
        SceneManager.LoadScene("Menu");
    }

}
