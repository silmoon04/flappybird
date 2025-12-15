using UnityEngine;
using Key = UnityEngine.InputSystem.Keyboard; 
public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRB;

    public float flapStr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private bool JumpPressed => Key.current != null && Key.current.spaceKey.wasPressedThisFrame; 
    void Update()
    {
        if (JumpPressed)
        {
            myRB.linearVelocity = Vector2.up * flapStr;
        }

    }
}
