using UnityEngine;

public class playermovement : MonoBehaviour
{

    public float speed = 5f;
    private Rigidbody rb;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontaal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");


            Vector3 direction = new Vector3(horizontaal, 0f, vertical);

           rb.linearVelocity = new Vector3(
               direction.x * speed,
               rb.linearVelocity.y,
               direction.z * speed);


    }
}
