using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_navigation : MonoBehaviour
{
    public void ScanClick()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
    
    public void QuizClick()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }
    public void AboutClick()
    {
        SceneManager.LoadScene(sceneBuildIndex: 3);
    }
    public void BackClick()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    public void SteamURL()
    {
        Application.OpenURL("https://steamcommunity.com/id/fxlja1411/");
    }

    public void DiscordURL()
    {
        Application.OpenURL("https://discordapp.com/users/4106");
    }

    public void GithubURL()
    {
        Application.OpenURL("https://github.com/FXLJA");
    }
}
