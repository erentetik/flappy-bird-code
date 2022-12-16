using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Birdy : MonoBehaviour
{
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    public bool isDead;
    public GameManage managerGame;
    public GameObject DeathScreen;

    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown("space")){
            rb2D.velocity = Vector2.up * velocity;
         }
        if(Input.GetMouseButtonDown(0)){
                    rb2D.velocity = Vector2.up * velocity;           
            }
    } 

    private void OnTriggerEnter2D(Collider2D collison){
        if(collison.gameObject.name == "ScoreArea"){
            managerGame.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collison){
        if(collison.gameObject.tag == "DeathArea"){
            isDead = true;
            Time.timeScale = 0;
          

            DeathScreen.SetActive(true);
        }
    }
}
