using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    public void changeToGeral()
    {
        SceneManager.LoadScene("Geral");
    }

    public void changeToProgramacao()
    {
        SceneManager.LoadScene("Prog");
    }

    public void changeToDesign()
    {
        SceneManager.LoadScene("Design");
    }

    public void changeToArtes()
    {
        SceneManager.LoadScene("Arte");
    }

    public void returnToPrincipal()
    {
        SceneManager.LoadScene("Principal");
    }

}
