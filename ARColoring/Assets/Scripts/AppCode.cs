using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppCode : MonoBehaviour
{
    public Text Ctext;
    public GameObject[] players;
    public string[] words;
    int n = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < players.Length; i++)
        {
            players[i].SetActive(false);
        }
        players[n].SetActive(true);
        Ctext.text = words[n];
        n = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick() {
        if (n < players.Length)
        {
            players[n - 1].SetActive(false);
            players[n].SetActive(true);
            Ctext.text = words[n];
            n++;
        }
        else if (n >= players.Length) {
            players[n-1].SetActive(false);
            n = 1;
            players[n-1].SetActive(true);
            Ctext.text = words[n-1];
        }
    }
}
