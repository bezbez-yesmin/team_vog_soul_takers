using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    public GameObject panel;
    public Text ScoreText;
    public int score = 0;
    public GameObject coincollectore;
    public TagAttribute Coin;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "coin")
        {
            col.gameObject.SetActive(false);
            score++;
            ScoreText.text = score.ToString();
            Debug.Log(score);
        }
    }
    private void Update()
    {
        if (score == 3)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
        }
        if (score < 3)
        {
            Time.timeScale = 1;
        }

    }
}

