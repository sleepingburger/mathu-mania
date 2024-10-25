using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{


    bool showUI = true;
    public int activePanel = 0;
    public GameObject[] panels;
    /// <summary>
    /// Enable the menu when the object is enabled.
    /// </summary>
    void OnEnable() {
        ToggleMainMenu(showUI); 
    }


    public void ToggleMainMenu(bool toggle){
        if(toggle){
            Time.timeScale = 0;
            
        }else{
            panels[activePanel].SetActive(false);
            Time.timeScale = 1;
        }
    }

        /// <summary>
        /// If the escape key is pressed, toggle the main menu on, and set the active panel to 1.
        /// </summary>
    void Update()   
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            setActivePanel(1);
            ToggleMainMenu(true);
        }
    }

    public void setActivePanel(int index){
        for (var i = 0; i < panels.Length; i++){
            var active = i == index;
            var g = panels[i];
            if (g.activeSelf != active) g.SetActive(active);
        }
    }
    
}
