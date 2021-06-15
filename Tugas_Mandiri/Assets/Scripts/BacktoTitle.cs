using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoTitle : MonoBehaviour
{
    public void LoadTitle()
    {
        StartCoroutine(delay_load());
    }

    IEnumerator delay_load()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
}
