using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour
{
    public static scoremanager instance;
    private string sceneName;
    public static float stage1,stage2,stage3,stage4,stage5,stage6,stage7,stage8,totalSeconds;
    public static float stage1final,stage2final,stage3final,stage4final,stage5final,stage6final,stage7final,stage8final;

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        sceneName=scene.name;
        updateTime();
    }
    private void Awake() 
    {
        DontDestroyOnLoad(gameObject);    
    }

    void updateTime()
    {
        if(sceneName=="MainMenu")
        {
            ResetScore();
        }
        if(sceneName=="Stage1")
        {
            stage1 += Time.deltaTime;
            totalSeconds += Time.deltaTime;
        }
        if(sceneName=="Stage2")
        {
            stage2 += Time.deltaTime;
            totalSeconds += Time.deltaTime;
        }
        if(sceneName=="Stage3")
        {
            stage3 += Time.deltaTime;
            totalSeconds += Time.deltaTime;
        }
        if(sceneName=="Stage4")
        {
            stage4 += Time.deltaTime;
            totalSeconds += Time.deltaTime;
        }
        if(sceneName=="Stage5")
        {
            stage5 += Time.deltaTime;
            totalSeconds += Time.deltaTime;
        }
        if(sceneName=="Stage6")
        {
            stage6 += Time.deltaTime;
            totalSeconds += Time.deltaTime;
        }
        if(sceneName=="Stage7")
        {
            stage7 += Time.deltaTime;
            totalSeconds += Time.deltaTime;
        }
        if(sceneName=="Stage8")
        {
            stage8 += Time.deltaTime;
            totalSeconds += Time.deltaTime;
        }
    }    
    public void setscore()
    {
        if(sceneName=="Stage1")
        {
            stage1final = stage1;
        }
        if(sceneName=="Stage2")
        {
            stage2final = stage2;
        }
        if(sceneName=="Stage3")
        {
            stage3final = stage3;
        }
        if(sceneName=="Stage4")
        {
           stage4final = stage4;
        }
        if(sceneName=="Stage5")
        {
            stage5final = stage5;
        }
        if(sceneName=="Stage6")
        {
            stage6final = stage6;
        }
        if(sceneName=="Stage7")
        {
            stage7final = stage7;
        }
        if(sceneName=="Stage8")
        {
            stage8final = stage8;
        }
    }
    public void ResetScore()
    {
        stage1final = 0;
        stage2final = 0;
        stage3final = 0;
        stage4final = 0;
        stage5final = 0;
        stage6final = 0;
        stage7final = 0;
        stage8final = 0;
        stage1 = 0;
        stage2 = 0;
        stage3 = 0;
        stage4 = 0;
        stage5 = 0;
        stage6 = 0;
        stage7 = 0;
        stage8 = 0;
        totalSeconds = 0;
    }
    public void ResetStageScore()
    {
        if(sceneName=="Stage1")
        {
            totalSeconds = totalSeconds - stage1;
            stage1 = 0;
        }
        if(sceneName=="Stage2")
        {
            totalSeconds = totalSeconds - stage2;
            stage2 = 0;
        }
        if(sceneName=="Stage3")
        {
            totalSeconds = totalSeconds - stage3;
            stage3 = 0;
        }
        if(sceneName=="Stage4")
        {
           totalSeconds = totalSeconds - stage4;
            stage4 = 0;
        }
        if(sceneName=="Stage5")
        {
            totalSeconds = totalSeconds - stage5;
            stage5= 0;
        }
        if(sceneName=="Stage6")
        {
            totalSeconds = totalSeconds - stage6;
            stage6 = 0;
        }
        if(sceneName=="Stage7")
        {
            totalSeconds = totalSeconds - stage7;
            stage7 = 0;
        }
        if(sceneName=="Stage8")
        {
            totalSeconds = totalSeconds - stage8;
            stage8 = 0;
        }
    }
}
