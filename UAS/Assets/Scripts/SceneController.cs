using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
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

    public void Quit()
    {
        Application.Quit();
    }
}
