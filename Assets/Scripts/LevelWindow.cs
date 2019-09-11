using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelWindow : MonoBehaviour
{
    private Text levelText;
    private Image experienceBarImage;
    private LevelSystem levelSystem;


    private void Awake()
    {
        levelText = transform.Find("levelText").GetComponent<Text>();
        experienceBarImage = transform.Find("xpBar").Find("Bar").GetComponent<Image>();

    }

    private void SetExperienceBarSize(float experienceNormalized)
    {
        experienceBarImage.fillAmount = experienceNormalized;
    }

    private void SetLevelNumber(int levelNumber)
    {
        levelText.text = " " + (levelNumber + 1);
    }

    public void SetLevelSystem(LevelSystem levelSystem)
    {
        this.levelSystem = levelSystem;

        SetLevelNumber(levelSystem.getLevelNumber());
        SetExperienceBarSize(levelSystem.GetExperienceNormalized());

        levelSystem.OnExperienceChanged += levelSystem_OnExperienceChanged;
        levelSystem.OnLevelChanged += levelSystem_OnLevelChanged;
    }
     
    private void levelSystem_OnLevelChanged(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void levelSystem_OnExperienceChanged(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

}
