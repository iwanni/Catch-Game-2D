﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    public int ballValue;
    private int score;

	// Use this for initialization
	void Start () {
		score  = 0;
        UpdateScore();
	}

    private void OnTriggerEnter2D()
    {
        score = score + ballValue;
        UpdateScore();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bomb")
        {
            score = score - ballValue * 2;
            UpdateScore();
        }
    }

    // Update is called once per frame
    void UpdateScore () {
		scoreText.text = "Score:\n" + score;
	}
}
