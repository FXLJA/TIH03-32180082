using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class LevelIdentifikasi : MonoBehaviour
{
    public UnityEvent OnCorrectAnswer;
    public UnityEvent OnWrongAnswer;
    public UnityEvent OnOutofQuestion;
    public Sprite[] images;
    public Image display;
    List<int> pool_int = new List<int>();
    int curr_question;
    int curr_answer = -1;

    void Start()
    {
        InitPool(images.Length);
        NextQuestion();
    }

    void InitPool(int total) {
        for(int i=0; i<total; i++) {
            pool_int.Add(i);
        }
        Shuffle(pool_int);
    }

    public void NextQuestion() {
        if(pool_int.Count > 0) {
            int index = pool_int[0];
            pool_int.RemoveAt(0);

            display.sprite = images[index];
            curr_question = index;
        } else {
            OnOutofQuestion.Invoke();
        }
    }

    public void CheckAnswer() {
        if (curr_question == curr_answer) {
            OnCorrectAnswer.Invoke();
        } else {
            OnWrongAnswer.Invoke();
        }
    }

    public void SetCurrAnswer(int answer) {
        curr_answer = answer;
    }

    public void CheckAnswer_And_NextQuestion() {
        CheckAnswer();
        NextQuestion();
    }

    void Shuffle(List<int> ts) {
        var count = ts.Count;
        var last = count - 1;
        for (var i = 0; i < last; ++i) {
            var r = Random.Range(i, count);
            var tmp = ts[i];
            ts[i] = ts[r];
            ts[r] = tmp;
        }
    }
}
