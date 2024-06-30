using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    
    public float health;
    bool dead = false;
    
    void Start()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetFloat("health",3);
       
    }

    // Update is called once per frame
    void Update()
    {
        health = PlayerPrefs.GetFloat("health");
        
    }
    public void GetDamage(float damage)
    {
        if((PlayerPrefs.GetFloat("health") > 0))
        {
            health = PlayerPrefs.GetFloat("health"); 
        }

        AmIDead();
    }
    void AmIDead()
    {
        if(PlayerPrefs.GetFloat("health") <= 0)
        {
            dead = true;
          
        }
      
    }
  

}
