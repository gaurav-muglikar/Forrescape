﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadGameScene(){
        SceneChanger.DontDestroyOnLoad(gameObject);
        ChangeScene.LoadNewScene(ChangeScene.scene.GameScene);
    }
    public void QuitGame(){
        QuitGame();
    }
}
