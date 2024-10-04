using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class startScript : MonoBehaviour
{
    public GameObject startMenu;
    // Start is called before the first frame update
    void Start()
    {
        pause();
    }

    public void pause()
    {
        Time.timeScale = 0;
        startMenu.SetActive(true);
    }

    public void resume()
    {
        Time.timeScale = 1;
        startMenu.SetActive(false);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
