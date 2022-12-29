using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class trashlose : MonoBehaviour
{
    public GameObject panel;
    public Text liveText;
    public int lives = 3;
    public GameObject loselife;
    public TagAttribute trach;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "trash")
        {
            col.gameObject.SetActive(false);
            lives=lives-1;
            liveText.text = lives.ToString();
            Debug.Log(lives);
        }
    }
    private void Update()
    {
        if (lives == 0)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
        }
        if (lives >0)
        {
            Time.timeScale = 1;
        }

    }
}
