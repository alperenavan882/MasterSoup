using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tencereSystem : MonoBehaviour
{
    public SpriteRenderer[] tencereler;
    public GameObject tencere;

    public GameObject panel;
    void Start()
    {
        PlayerPrefs.SetInt("tencereSayi", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("tencereSayi") == 0)
        {
            tencere.GetComponent<SpriteRenderer>().sprite = tencereler[0].GetComponent<SpriteRenderer>().sprite;
        }
        if (PlayerPrefs.GetInt("tencereSayi") == 2)
        {
            tencere.GetComponent<SpriteRenderer>().sprite = tencereler[1].GetComponent<SpriteRenderer>().sprite;
        }
        if (PlayerPrefs.GetInt("tencereSayi") == 4)
        {
            tencere.GetComponent<SpriteRenderer>().sprite = tencereler[2].GetComponent<SpriteRenderer>().sprite;
        }
        if (PlayerPrefs.GetInt("tencereSayi") == 6)
        {
            tencere.GetComponent<SpriteRenderer>().sprite = tencereler[3].GetComponent<SpriteRenderer>().sprite;
        }
        if (PlayerPrefs.GetInt("tencereSayi") == 8)
        {
            tencere.GetComponent<SpriteRenderer>().sprite = tencereler[4].GetComponent<SpriteRenderer>().sprite;
        }
        if (PlayerPrefs.GetInt("tencereSayi") == 10)
        {
            tencere.GetComponent<SpriteRenderer>().sprite = tencereler[5].GetComponent<SpriteRenderer>().sprite;
            if(!panel.activeSelf)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter) && panel.activeSelf)
        {
            Application.LoadLevel("ChefDanilo");
        }
    }
}
