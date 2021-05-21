using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.SceneManagement; 

public class ScriptMenu : MonoBehaviour 
{ 
    public GameObject ConfirmPanel; 
    public GameObject AboutPanel;

    public void Exit() 
    { 
        Application.Quit(); 
    }

    public void Play(string scene_name) 
    {
        SceneManager.LoadScene(scene_name); 
    }

    public void ConfirmClicked() 
    { 
        ConfirmPanel.SetActive(true); 
        AboutPanel.SetActive(false); 
    }

    public void AboutClicked() 
    {
        ConfirmPanel.SetActive(false); 
        AboutPanel.SetActive(true);
    }

    public void Back()
    {
        ConfirmPanel.SetActive(false);
    }
}