﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScene3 : MonoBehaviour
{
    public void GoToGame()
    {
        SceneManager.LoadScene("Flight3");
    }
}