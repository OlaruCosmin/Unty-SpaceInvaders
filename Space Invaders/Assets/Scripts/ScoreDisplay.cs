using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreDisplay : MonoBehaviour {

    Text scoreText;
    GameSesion gameSesion;

    void Start()
    {
        scoreText = GetComponent<Text>();
        gameSesion = FindObjectOfType<GameSesion>();
    }

    void Update()
    {
        scoreText.text = gameSesion.GetScore().ToString();
    }

}
