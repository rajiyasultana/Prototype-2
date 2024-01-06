using UnityEngine;

public class Enmey : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDIrection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDIrection * speed);
    }
}
