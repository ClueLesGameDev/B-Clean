using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class MainGame_Quiz : MonoBehaviour
{
    [SerializeField]
    private GameObject QuestionBox;

    public TextAsset QuestionsText;
    public TextAsset AnswerText;

    private Dictionary<int, string> QuestionBank = new Dictionary<int, string>();
    
    private Dictionary<int, string> OptionSet = new Dictionary<int, string>();
    
    private Dictionary<int, string> AnswerSet = new Dictionary<int, string>();

   
    
    private void Start()
    {
        LoadQuestions();

       // LoadOptions();

        LoadAnswers();

        QuestionSetGenerator();
    }

    void LoadQuestions()
    {
        string Qtemp = null;
        string Qlines = QuestionsText.text;
        int count = 0;
        for (int i = 0; i < Qlines.Length; i++)
        {
            Qtemp += Qlines[i];
            if (Qlines[i] == '\n')
            {
                QuestionBank.Add(count, Qtemp);
                count++;
                Qtemp = null;

            }
        }
    }


    //void LoadOptions()
    //{

    //}


    void LoadAnswers()
    {
        string Atemp = null;
        string Alines = AnswerText.text;
        int count = 0;
        for (int i = 0; i < Alines.Length; i++)
        {
            Atemp += Alines[i];
            if (Alines[i] == '\n')
            {
                AnswerSet.Add(count, Atemp);
                count++;
                Atemp = null;

            }
        }
    }

    void QuestionSetGenerator()
    {
        int randomNo = Random.Range(0, QuestionBank.Count);
        string currentQuest = QuestionBank[randomNo];

        QuestionBox.GetComponent<Text>().text = currentQuest;
    }

   
}
