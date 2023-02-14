using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class recordmenu : MonoBehaviour
{
    public Button Back;
    private static float totalMin,stage1,stage2,stage3,stage4,stage5,stage6,stage7,stage8, total; 
    private int stage1Min,stage2Min,stage3Min,stage4Min,stage5Min,stage6Min,stage7Min,stage8Min;
    public Text stage1Text,stage2Text,stage3Text,stage4Text,stage5Text,stage6Text,stage7Text,stage8Text,totalText;

    private void Start() 
    {
        Back.onClick.AddListener(Menu);
        toggleScore();
    }
    private void Menu() 
    {
        SceneManager.LoadScene("Menu");
    }
    public void toggleScore()
    {
        stage1 = scoremanager.stage1final;
        stage2 = scoremanager.stage2final;
        stage3 = scoremanager.stage3final;
        stage4 = scoremanager.stage4final;
        stage5 = scoremanager.stage5final;
        stage6 = scoremanager.stage6final;
        stage7 = scoremanager.stage7final;
        stage8 = scoremanager.stage8final;
        total = 0;
        totalMin=0;
        total = stage1+stage2+stage3+stage4+stage5+stage6+stage7+stage8;
        
        while(stage1>=60)
        {
            stage1Min++;
            stage1=stage1-60;
        }
        while(stage1>=60)
        {
            stage2Min++;
            stage2=stage2-60;
        }
        while(stage3>=60)
        {
            stage3Min++;
            stage3=stage3-60;
        }
        while(stage4>=60)
        {
            stage4Min++;
            stage4=stage4-60;
        }
        while(stage5>=60)
        {
            stage5Min++;
            stage5=stage5-60;
        }
        while(stage6>=60)
        {
            stage6Min++;
            stage6=stage6-60;
        }
        while(stage7>=60)
        {
            stage7Min++;
            stage7=stage7-60;
        }
        while(stage8>=60)
        {
            stage8Min++;
            stage8=stage8-60;
        }
        while(total>=60)
        {
            totalMin++;
            total=total-60;
        }
        stage1Text.text = stage1Min.ToString("00")+":"+stage1.ToString("00"); 
        stage2Text.text = stage2Min.ToString("00")+":"+stage2.ToString("00"); 
        stage3Text.text = stage3Min.ToString("00")+":"+stage3.ToString("00"); 
        stage4Text.text = stage4Min.ToString("00")+":"+stage4.ToString("00"); 
        stage5Text.text = stage5Min.ToString("00")+":"+stage5.ToString("00"); 
        stage6Text.text = stage6Min.ToString("00")+":"+stage6.ToString("00"); 
        stage7Text.text = stage7Min.ToString("00")+":"+stage7.ToString("00"); 
        stage8Text.text = stage8Min.ToString("00")+":"+stage8.ToString("00"); 
        totalText.text = totalMin.ToString("00")+":"+total.ToString("00");
    }
    private void Update() 
    {
        
    }
}
