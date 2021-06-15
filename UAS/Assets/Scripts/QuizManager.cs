using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class QuizManager : MonoBehaviour
{
    public UnityEvent On_Answer_Correct;
    public UnityEvent On_Answer_Wrong;
    public UnityEvent On_Out_of_Question;
    public string quiz_table_name;
    public Text lbl_soal;
    public Transform[] options;
    public Transform tempat_model;
    public GameObject[] models;
    public Sprite[] buttonSprites;
    List<int> pool_int = new List<int>();
    List<Question> questions;
    Question curr_question;
    string[] pilihan;
    int curr_question_index;
    bool hasStart = false;

    void Start() {
        StartGame();
    }

    public void StartGame() {
        if(hasStart) return;
        hasStart = true;

        QuizDatabase.InitDatabase();
        questions = QuizDatabase.database[quiz_table_name];

        int total = questions.Count;
        InitPool(total);

        NextQuestion();
    }

    public void NextQuestion() {
        if(pool_int.Count > 0) {
            int index = pool_int[0];
            pool_int.RemoveAt(0);

            curr_question_index = index;
            curr_question = questions[index];

            pilihan = (string[]) curr_question.pilihan.Clone();
            Shuffle(pilihan);

            DisplayQuestion();
        } else {
            On_Out_of_Question.Invoke();
        }
    }

    public void CheckAnswer(int option) {
        if (curr_question.pilihan[curr_question.jawaban].Equals(pilihan[option])) {
            On_Answer_Correct.Invoke();
        } else {
            On_Answer_Wrong.Invoke();
        }
    }

    public void CheckAnswer_And_NextQuestion(int option) {
        CheckAnswer(option);
        NextQuestion();
    }

    void DisplayQuestion() {
        lbl_soal.text = curr_question.soal;

        for(int i=0; i<pilihan.Length; i++) {
            options[i].GetComponentInChildren<Text>().text = pilihan[i];
        }
        for(int i=0; i<options.Length; i++) {
            options[i].gameObject.SetActive(i<pilihan.Length);
        }

        if(models.Length > 0) {
            Transform[] children = tempat_model.GetComponentsInChildren<Transform>();
            foreach(Transform child in children) {
                if(child != tempat_model) {
                    Destroy(child.gameObject, 0.01f);
                }
            }
            Instantiate(models[curr_question.prefab_index], tempat_model);
        }

        if(buttonSprites.Length > 0) {
            for(int k=0; k<pilihan.Length; k++) {
                for(int i=0; i<options.Length; i++) {
                    if(pilihan[k].Equals(curr_question.pilihan[i])) {
                        options[k].GetComponent<Image>().sprite = buttonSprites[curr_question_index * 3 + i];
                        break;
                    }
                }
            }
        }
    }

    void InitPool(int total) {
        for(int i=0; i<total; i++) {
            pool_int.Add(i);
        }
        Shuffle(pool_int);
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

    void Shuffle(string[] ts) {
        var count = ts.Length;
        var last = count - 1;
        for (var i = 0; i < last; ++i) {
            var r = Random.Range(i, count);
            var tmp = ts[i];
            ts[i] = ts[r];
            ts[r] = tmp;
        }
    }
}
