using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float sepetSpeed;
    public GameObject[] liste;
    public Sprite tick, cross;

    public GameObject[] sepetIci;

    public GameObject[] paneller;

    public AudioSource audio;
    public AudioClip dogru, yanlis;

    void Start()
    {
        Time.timeScale = 1;
        paneller[0].SetActive(true);
        paneller[1].SetActive(false);
        paneller[2].SetActive(false);
        sepetIci[0].SetActive(false);
        sepetIci[1].SetActive(false);
        sepetIci[2].SetActive(false);
        sepetIci[3].SetActive(false);
        sepetIci[4].SetActive(false);
        sepetSpeed = 10f;
        PlayerPrefs.SetFloat("domates", 0);
        PlayerPrefs.SetFloat("kabak", 0);
        PlayerPrefs.SetFloat("patates", 0);
        PlayerPrefs.SetFloat("sogan", 0);
        PlayerPrefs.SetFloat("tavuk", 0);
        PlayerPrefs.SetFloat("lvlCheck1", 0);

        liste[0].GetComponent<Image>().sprite = cross;
        liste[1].GetComponent<Image>().sprite = cross;
        liste[2].GetComponent<Image>().sprite = cross;
        liste[3].GetComponent<Image>().sprite = cross;
        liste[4].GetComponent<Image>().sprite = cross;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "domates")
        {
            audio.PlayOneShot(dogru);
            Destroy(GameObject.FindWithTag("domates"));
            PlayerPrefs.SetFloat("domates", 1);
            PlayerPrefs.SetFloat("lvlCheck1", PlayerPrefs.GetFloat("lvlCheck1") +1);

            sepetIci[0].SetActive(true);

            if (PlayerPrefs.GetFloat("lvlCheck1") == 5)
            {
                Time.timeScale = 0;
                paneller[0].SetActive(false);
                paneller[1].SetActive(false);
                paneller[2].SetActive(true);
            }
        }

        if (collision.gameObject.tag == "kabak")
        {
            audio.PlayOneShot(dogru);
            Destroy(GameObject.FindWithTag("kabak"));
            PlayerPrefs.SetFloat("kabak", 1);
            PlayerPrefs.SetFloat("lvlCheck1", PlayerPrefs.GetFloat("lvlCheck1") + 1);

            sepetIci[1].SetActive(true);

            if (PlayerPrefs.GetFloat("lvlCheck1") == 5)
            {
                Time.timeScale = 0;
                paneller[0].SetActive(false);
                paneller[1].SetActive(false);
                paneller[2].SetActive(true);
            }
        }

        if (collision.gameObject.tag == "patates")
        {
            audio.PlayOneShot(dogru);
            Destroy(GameObject.FindWithTag("patates"));
            PlayerPrefs.SetFloat("patates", 1);
            PlayerPrefs.SetFloat("lvlCheck1", PlayerPrefs.GetFloat("lvlCheck1") + 1);

            sepetIci[2].SetActive(true);

            if (PlayerPrefs.GetFloat("lvlCheck1") == 5)
            {
                Time.timeScale = 0;
                paneller[0].SetActive(false);
                paneller[1].SetActive(false);
                paneller[2].SetActive(true);
            }
        }

        if (collision.gameObject.tag == "sogan")
        {
            audio.PlayOneShot(dogru);
            Destroy(GameObject.FindWithTag("sogan"));
            PlayerPrefs.SetFloat("sogan", 1);
            PlayerPrefs.SetFloat("lvlCheck1", PlayerPrefs.GetFloat("lvlCheck1") + 1);

            sepetIci[3].SetActive(true);

            if (PlayerPrefs.GetFloat("lvlCheck1") == 5)
            {
                Time.timeScale = 0;
                paneller[0].SetActive(false);
                paneller[1].SetActive(false);
                paneller[2].SetActive(true);
            }
        }

        if (collision.gameObject.tag == "tavuk")
        {
            audio.PlayOneShot(dogru);
            Destroy(GameObject.FindWithTag("tavuk"));
            PlayerPrefs.SetFloat("tavuk", 1);
            PlayerPrefs.SetFloat("lvlCheck1", PlayerPrefs.GetFloat("lvlCheck1") + 1);

            sepetIci[4].SetActive(true);

            if (PlayerPrefs.GetFloat("lvlCheck1") == 5)
            {
                Time.timeScale = 0;
                paneller[0].SetActive(false);
                paneller[1].SetActive(false);
                paneller[2].SetActive(true);
            }
        }

        if (collision.gameObject.tag == "brokoliSoup")
        {
            audio.PlayOneShot(yanlis);
            Destroy(GameObject.FindWithTag("brokoliSoup"));
            Destroy(GameObject.FindWithTag("tavuk"));
            Destroy(GameObject.FindWithTag("sogan"));
            Destroy(GameObject.FindWithTag("patates"));
            Destroy(GameObject.FindWithTag("kabak"));
            Destroy(GameObject.FindWithTag("domates"));

            Time.timeScale = 0;
            paneller[0].SetActive(false);
            paneller[1].SetActive(true);
            paneller[2].SetActive(false);
        }

    }



    void Update()
    {
        float keyCont = Input.GetAxis("Horizontal");

        transform.Translate(keyCont * Time.deltaTime * sepetSpeed, 0, 0);

        if(Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Application.LoadLevel("ChefMehmet");
        }


        if (PlayerPrefs.GetFloat("domates") == 1)
        {
            {
                liste[0].GetComponent<Image>().sprite = tick;
            }
        }

        if (PlayerPrefs.GetFloat("kabak") == 1)
        {
            {
                liste[1].GetComponent<Image>().sprite = tick;
            }
        }

        if (PlayerPrefs.GetFloat("patates") == 1)
        {
            {
                liste[2].GetComponent<Image>().sprite = tick;
            }
        }

        if (PlayerPrefs.GetFloat("sogan") == 1)
        {
            {
                liste[3].GetComponent<Image>().sprite = tick;
            }
        }

        if (PlayerPrefs.GetFloat("tavuk") == 1)
        {
            {
                liste[4].GetComponent<Image>().sprite = tick;
            }
        }


    }
}
