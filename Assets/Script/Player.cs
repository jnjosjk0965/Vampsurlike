using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    // Players Health
    [SerializeField] int maxHealth = 100;
    [SerializeField] int currentHealth;
    [SerializeField] HealthBar healthBar;
    // Players speed
    [SerializeField] float playerSpeed;
    public Vector2 inputVec;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator anime;
    void Awake() {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anime = GetComponent<Animator>();
    }
    void Start() {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }
    private void FixedUpdate() {
        Vector2 nextVec = inputVec * playerSpeed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
    }
    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            TakeDamage(20);
        }
    }
    private void LateUpdate() {
        anime.SetFloat("Speed", inputVec.magnitude);
        if(inputVec.x != 0){
            spriteRenderer.flipX = inputVec.x < 0;
        }
    }
    void OnMove(InputValue value) {
        inputVec = value.Get<Vector2>();
    }
    void TakeDamage(int Damage) {
        currentHealth -= Damage;
        healthBar.SetHealth(currentHealth);
    }

    
}
