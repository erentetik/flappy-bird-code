using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Birdy Birdscript;
    public GameObject Pipes;
    public float height;
    
     void Start()
    {
        StartCoroutine(SpawnObject());
    }
    public IEnumerator SpawnObject(){
        while(!Birdscript.isDead){

        Instantiate (Pipes, new Vector3(2, Random.Range(-height, height), 0), Quaternion.identity);
        yield return new WaitForSeconds(2f);

        }
    }
}
