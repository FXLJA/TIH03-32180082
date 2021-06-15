using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text lbl_skor;
    public int max_score = 3;
    int total_skor = 0;

    public void AddSkor(int jumlah) {
        total_skor += jumlah;
        lbl_skor.text = "Skor : " + total_skor.ToString() + "/" + max_score.ToString();
    }
}
