using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public UnityEvent OnGameOver;
    public StarSpawner star_spawner;
    public Text lbl_score;
    public Text lbl_timer;
    int score = 0;
    int timer = 30;
    bool isGameOver = false;

    void Start()
    {
        lbl_timer.text = "" + timer;
        GameObject obj = star_spawner.SpawnStar();
        obj.GetComponent<StarScript>().OnInteract.AddListener(OnStarInteract);
        StartCoroutine(TickDownTime());
    }

    IEnumerator TickDownTime() {
        while(!isGameOver) {
            yield return new WaitForSeconds(1);
            timer--;
            lbl_timer.text = "" + timer;

            if(timer <= 0) {
                isGameOver = true;
                OnGameOver.Invoke();
            }
        }
    }

    IEnumerator GameOver() {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }

    void OnTriggerEnter(Collider collider){
        Destroy(collider.gameObject);

        if(!isGameOver) {
            OnGameOver.Invoke();
            StartCoroutine(GameOver());
        }
    }

    void OnStarInteract() {
        if(!isGameOver) {
            score++;
            lbl_score.text = "" + score;
            
            GameObject obj = star_spawner.SpawnStar();
            obj.GetComponent<StarScript>().OnInteract.AddListener(OnStarInteract);

            timer += 5;
            lbl_timer.text = "" + timer;
        }
    }
}
