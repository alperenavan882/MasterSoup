using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject crewPanel;

    void Start()
    {
        crewPanel.SetActive(false);
    }
    public void sahneAtl()
    {
        SceneManager.LoadScene("ChefSomer");
    }

    public void credits()
    {
        crewPanel.SetActive(true);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && crewPanel.activeSelf)
        {
            crewPanel.SetActive(false);
        }
    }
}
