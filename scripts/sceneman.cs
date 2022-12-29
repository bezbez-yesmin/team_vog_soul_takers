using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void returnmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void returnlevels()
    {
        SceneManager.LoadScene(1);
    }
    public void returngameinfo()
    {
        SceneManager.LoadScene(2);
    }
    public void returnlevel1info()
    {
        SceneManager.LoadScene(3);
            
    }
    public void returnlevel1game()
    {
        SceneManager.LoadScene(4);
    }
    public void returnlevel2info()
    {
        SceneManager.LoadScene(5);
    }
    public void returnlevel2game() 
    {
        SceneManager.LoadScene(6);
    }
    public void returnlevel3info()
    {
        SceneManager.LoadScene(7);
    }
    public void returnlevel3game() 
    {
        SceneManager.LoadScene(8);
    }
    public void exitGame()
    {
        Application.Quit();
    }
}

