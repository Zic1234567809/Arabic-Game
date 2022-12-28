using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour{
    public GameObject pauseMenu;
    void Start(){
        DontDestroyOnLoad(gameObject);
    }void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(pauseMenu.activeInHierarchy){
                Resume();
            }
            Pause();
        }
    }void Pause(){
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        FindObjectOfType<playerPlasRandomQuestion>().enabled = false;
    }public void Resume(){
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        FindObjectOfType<playerPlasRandomQuestion>().enabled = true;
    }public void Quit(){
        Application.Quit();
    }
}