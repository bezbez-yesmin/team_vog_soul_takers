using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class game2 : MonoBehaviour
{
    public GameObject panel;
    public Text ScoreText;
    public int score = 0;
    public GameObject boat;
    public TagAttribute player;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "palyer")
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


