using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int health = 3;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public GameObject panel;

    void Start()
    {
        panel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetFloat("health")==3)
        {
            hearts[0].sprite = fullHeart;
            hearts[1].sprite = fullHeart;
            hearts[2].sprite = fullHeart;
        }
        if (PlayerPrefs.GetFloat("health") == 2)
        {
            hearts[0].sprite = fullHeart;
            hearts[1].sprite = fullHeart;
            hearts[2].sprite = emptyHeart;
        }
        if (PlayerPrefs.GetFloat("health") == 1)
        {
            hearts[0].sprite = fullHeart;
            hearts[1].sprite = emptyHeart;
            hearts[2].sprite = emptyHeart;
        }
        if(PlayerPrefs.GetFloat("health") == 0)
        {

            hearts[0].sprite = emptyHeart;
            hearts[1].sprite = emptyHeart;
            hearts[2].sprite = emptyHeart;

            panel.SetActive(true);
            Time.timeScale = 0;
        }

       if(Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

    }
  
}
