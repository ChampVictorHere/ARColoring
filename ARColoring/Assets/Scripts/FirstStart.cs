using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstStart : MonoBehaviour
{
    public GameObject questionBtn;
    public GameObject TextQuestion;
    public Text Qtext;

    public Text tValue;

    int point = 0;

    public void Save()
    {
        PlayerPrefs.SetInt("Key", point);
    }
    public void Load() {
        point = PlayerPrefs.GetInt("Key", 0);
        if (PlayerPrefs.HasKey("Key"))
        {

        }
        tValue.text = point.ToString();
    }
    public void Delete()
    {
        //PlayerPrefs.DeleteAll();
        PlayerPrefs.DeleteKey("Key");
    }
    public void Increase()
    {
        point++;
        tValue.text = point.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        Load();
        if(point > 0)
        {
            questionBtn.SetActive(false);
            TextQuestion.SetActive(false);
        }
        else
        {
            questionBtn.SetActive(true);
            TextQuestion.SetActive(true);
        }
    }
    public void QuestionClick()
    {
        questionBtn.SetActive(false);
        Qtext.text = "Наведите на метку";
        Increase();
        Save();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
