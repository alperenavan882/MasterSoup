using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplose : MonoBehaviour
{
    public AudioSource src;
    public AudioClip patlar;
    
    // Start is called before the first frame update
    void Start()
    {
        src.PlayOneShot(patlar);
        StartCoroutine(destroyThis());
    }

    IEnumerator destroyThis()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
