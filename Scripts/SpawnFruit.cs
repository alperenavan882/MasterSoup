using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class SpawnFruit : MonoBehaviour
{
    public List<GameObject> malzeme = new List<GameObject>();
    public List<GameObject> malzemeGame = new List<GameObject>();



    public float secondSpawn;

    public float minTras;

    public float maxTras;

    void Start()
    {
        malzemeGame = new List<GameObject>(malzeme);
        StartCoroutine(FruitSpawn());
    }

    public void startFunc()
    {
        StartCoroutine(FruitSpawn());
    }

    IEnumerator FruitSpawn()
    {
        while (malzemeGame.Count > 0)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            int rand = Random.Range(0, malzemeGame.Count);
            GameObject gameObject = Instantiate(malzemeGame[rand],position, Quaternion.identity);
            malzemeGame.Remove(malzemeGame[rand]);
            yield return new WaitForSeconds(secondSpawn);

        }

    }

}
