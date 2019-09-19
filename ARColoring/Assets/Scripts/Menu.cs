using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenLevel()
    {
        SceneManager.LoadScene(level);
        //Application.LoadLevel(level);
    }
    public void AppExit()
    {
        Application.Quit();
    }
}
