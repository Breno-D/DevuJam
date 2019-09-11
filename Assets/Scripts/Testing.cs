using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] private LevelWindow levelWindow;

    private void Awake()
    {
        LevelSystem levelSystem = new LevelSystem();
        Debug.Log(levelSystem.getLevelNumber());
        levelSystem.AddExperience(5);
        Debug.Log(levelSystem.getLevelNumber());
        levelSystem.AddExperience(6);
        Debug.Log(levelSystem.getLevelNumber());

        levelWindow.SetLevelSystem(levelSystem);
    }
}
 