using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -35;
    public float gapsize = 10f;

    private Transform topPipe;
    private Transform bottomPipe;
    private bool gapApplied = false;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        topPipe = transform.Find("TopPipe");
        bottomPipe = transform.Find("BottomPipe");


    }

    // Update is called once per frame
    void Update()
    {
        if (!gapApplied)
        {
            topPipe.localPosition = new Vector3(0, gapsize, 0);
            bottomPipe.localPosition = new Vector3(0, -gapsize, 0);
            gapApplied = true;

        }
        transform.position += Vector3.left * (moveSpeed  * Time.deltaTime);
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
