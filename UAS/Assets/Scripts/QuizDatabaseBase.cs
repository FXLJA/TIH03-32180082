using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizDatabaseBase
{
    public static Dictionary<string, List<Question>> database = new Dictionary<string, List<Question>>();
    static string curr_table_name;
    static List<Question> curr_table;

    protected static void CreateTable(string tbl_name) {
        curr_table_name = tbl_name;
        curr_table = new List<Question>();
    }

    protected static string[] CreatePilihan(params string[] pilihan) {
        return pilihan;
    }

    protected static void AddSoal(string soal, string[] pilihan) {
        Question q = new Question();
        q.soal = soal;
        q.pilihan = pilihan;
        q.jawaban = 0;
        q.prefab_index = curr_table.Count;

        curr_table.Add(q);
    }

    protected static void AddSoal(string soal, string[] pilihan, int answer_index) {
        Question q = new Question();
        q.soal = soal;
        q.pilihan = pilihan;
        q.jawaban = answer_index;
        q.prefab_index = curr_table.Count;

        curr_table.Add(q);
    }

    protected static void AddSoal(string soal, string[] pilihan, int answer_index, int prefab_index) {
        Question q = new Question();
        q.soal = soal;
        q.pilihan = pilihan;
        q.jawaban = answer_index;
        q.prefab_index = prefab_index;

        curr_table.Add(q);
    }

    protected static void SaveTable() {
        database[curr_table_name] = curr_table;
    }
}
