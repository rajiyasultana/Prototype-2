using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    // 2.
    private GameObject focalPoint;
    public float speed = 5.0f;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //2.
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        // playerRb.AddForce(Vector3.forward * speed * forwardInput); *** 1.This line is for ball or any obeject.
        //transform.Translate(Vector3.forward * speed * forwardInput * Time.deltaTime);
        //2.for force the player to move in the direction the camera are facing
        transform.Translate(focalPoint.transform.forward * speed * forwardInput * Time.deltaTime);
    }
}
