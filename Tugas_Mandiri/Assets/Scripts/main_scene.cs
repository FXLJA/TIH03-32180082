using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_scene : MonoBehaviour
{
    GameObject ConfirmPanel;
    private void Start()
    {
        ConfirmPanel = GameObject.FindGameObjectsWithTag("HidePanel")[0];
        ConfirmPanel.SetActive(false);
    }
    public void ExitClick()
    {
        ConfirmPanel.SetActive(true);
    }
    public void NoClick()
    {
        ConfirmPanel.SetActive(false);
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    public void YesClick()
    {
        Application.Quit();
    }
}
