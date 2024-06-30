using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGec : MonoBehaviour
{
    public string sahneAdi;
    public GameObject yaziText;

    void Start()
    {
        Time.timeScale = 1;
        yaziText.SetActive(true);
    }
    public void sahneAtla()
    {
        SceneManager.LoadScene(sahneAdi);
    }
}
