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
    public Transform ball;
    int score = 0;
    int timer = 30;
    bool isGameOver = false;
    bool hasStart = false;
    public void StartGame()
    {
        if(hasStart)
        {
            return;
        }
        
        hasStart = true;
        ball.transform.localPosition = Vector3.zero;
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
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
                StartCoroutine(GameOver());
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

    void Update()
    {
        if(!hasStart)
        {
            return;
        }

        if(ball.GetComponent<Rigidbody>().velocity.y < -50)
        {
            Destroy(ball.gameObject);

            if(!isGameOver) {
                OnGameOver.Invoke();
                StartCoroutine(GameOver());
            }            
        }
    }
}
