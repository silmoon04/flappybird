using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 11f;
    private Transform ground1;
    private Transform ground2;
    private Transform ground3;

    private float groundHalfWidth = 48.73f/2;
    private float resetThreshold;

    private float teleportationDistance;
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ground1 = transform.Find("Ground1");
        ground2 = transform.Find("Ground2");
        ground3 = transform.Find("Ground3");

        float spacing = ground3.position.x - ground2.position.x;
        teleportationDistance = spacing * 3;
        resetThreshold = -Camera.main.orthographicSize * Camera.main.aspect;

    }

    // Update is called once per frame
    void Update()
    {
        // moving entire parent
        ground1.position += Vector3.left * (moveSpeed  * Time.deltaTime);
        ground2.position += Vector3.left * (moveSpeed  * Time.deltaTime);
        ground3.position += Vector3.left * (moveSpeed  * Time.deltaTime);
        
        
        float ground1RightEdge = ground1.position.x + groundHalfWidth;
        if (ground1RightEdge < resetThreshold)
        {
            ground1.position += new Vector3(teleportationDistance, 0, 0);
        }
        
        float ground2RightEdge = ground2.position.x + groundHalfWidth;
        if (ground2RightEdge < resetThreshold)
        {
            ground2.position += new Vector3(teleportationDistance, 0, 0);
        }
        float ground3RightEdge = ground3.position.x + groundHalfWidth;
        if (ground3RightEdge < resetThreshold)
        {
            ground3.position += new Vector3(teleportationDistance, 0, 0);
        }
        

    }
}
