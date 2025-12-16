using System;
using UnityEngine;
using Key = UnityEngine.InputSystem.Keyboard; 
public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRB;
    public LogicScript logic;
    public float flapStr;
    public bool birdIsAlive = true;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }
    private bool JumpPressed => Key.current != null && Key.current.spaceKey.wasPressedThisFrame; 
    void Update()
    {
        if (JumpPressed && birdIsAlive)
        {
            myRB.linearVelocity = Vector2.up * flapStr;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
