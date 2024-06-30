using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    public GameObject explose;
    
    //private Manager manager;

    void Start() {
        //manager = GameObject.FindObjectOfType<Manager>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Fruit") {
            PlayerPrefs.SetInt("tencereSayi", PlayerPrefs.GetInt("tencereSayi") + 1);
            Destroy(other.gameObject);
            //manager.score += 1;
        }
        if(other.gameObject.tag == "Bomb") {
            PlayerPrefs.SetFloat("health", PlayerPrefs.GetFloat("health") - 1);
            GameObject gameObject = Instantiate(explose, transform.position, transform.rotation);

            Destroy(other.gameObject);

        }
    }
}
