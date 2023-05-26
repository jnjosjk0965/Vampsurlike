using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Players Health
    [SerializeField] int maxHealth = 100;
    [SerializeField] int currentHealth;
    [SerializeField] HealthBar healthBar;
    // Players speed
    [SerializeField] float playerMoveSpeed;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            TakeDamage(20);
        }
        if(Input.GetKey(KeyCode.W)){
            float moveAmount = playerMoveSpeed * Time.deltaTime;
            transform.Translate(0,moveAmount,0);
        }else if(Input.GetKey(KeyCode.S)){
            float moveAmount = playerMoveSpeed * Time.deltaTime;
            transform.Translate(0,-moveAmount,0);
        }
        if(Input.GetKey(KeyCode.D)){
            float moveAmount = playerMoveSpeed * Time.deltaTime;
            transform.Translate(moveAmount,0,0);
        }else if(Input.GetKey(KeyCode.A)){
            float moveAmount = playerMoveSpeed * Time.deltaTime;
            transform.Translate(-moveAmount,0,0);
        }
    }

    void TakeDamage(int Damage){
        currentHealth -= Damage;
        healthBar.SetHealth(currentHealth);
    }
}
