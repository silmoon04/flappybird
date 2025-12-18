using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 11f;
    private Transform[] groundSegments;

    private float groundHalfWidth = 48.73f/2;
    private float resetThreshold;

    private float teleportationDistance;
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        groundSegments = new Transform[]
        {
            transform.Find("Ground1"),
            transform.Find("Ground2"),
            transform.Find("Ground3")
        };

        float spacing = groundSegments[2].position.x - groundSegments[1].position.x;
        teleportationDistance = spacing * 3;
        resetThreshold = -Camera.main.orthographicSize * Camera.main.aspect;

    }

    // Update is called once per frame
    void Update()
    {
        foreach (var segment in groundSegments)
        {
            segment.position += Vector3.left * (moveSpeed * Time.deltaTime);

            float segmentRightEdge = segment.position.x + groundHalfWidth;
            if (segmentRightEdge < resetThreshold)
            {
                segment.position += new Vector3(teleportationDistance, 0, 0);
            }
        }


    }
}
