using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppCode : MonoBehaviour
{
    public Text Ctext;
    public Mark[] marks;
    int n = 0;
    // Start is called before the first frame update
    void Start()
    {
        marks[n].getObj(name).SetActive(true);
        Ctext.text = marks[n].name;
        n = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AppMethod()
    {
        if (n < marks.Length)
        {
            marks[n-1].getObj(name).SetActive(false);
            marks[n].getObj(name).SetActive(true);
            Ctext.text = marks[n].name;
            n++;
        }
        else if (n >= marks.Length)
        {
            marks[n - 1].getObj(name).SetActive(false);
            n = 1;
            marks[n - 1].getObj(name).SetActive(true);
            Ctext.text = marks[n-1].name;
        }
    }
}
[Serializable]
public class Mark
{
    [SerializeField]
    public string name;
    [SerializeField]
    public GameObject gObject;
    public GameObject getObj(string name)
    {
        return gObject;
    }
}