﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathScript : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {
        SceneManager.LoadScene("GameOver");
    }
}
