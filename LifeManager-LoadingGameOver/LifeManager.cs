using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public static scoremanager instance;
    public static int lives;
    
    private void Awake() 
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        lives = 3;
        death();
    }
    public void LifeLost()
    {
        lives = lives - 1;
        death();
    }
    public void RestoreLife()
    {
        lives = 3;
        death();
    }
    public void GainOneLife()
    {
        lives = lives + 1;
        death();
    }
    private void death() 
    {
        if(lives <= 0)
        {
            Invoke("gameover", 2f);
        }
    }
    private void gameover()
    {
        SceneManager.LoadScene("GameOver");
    }
}
