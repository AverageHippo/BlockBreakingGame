﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    public void loadNextScene() {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex + 1 == SceneManager.sceneCountInBuildSettings) {
            SceneManager.LoadScene(0);
        } else {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }

    public void quitGame() {
        Application.Quit();
    }

}
