using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5.0f;

    public float jumpForce = 5.5f;

    private Rigidbody rb;

    public float speedDecreaseRate = 5.0f; // �ӵ��� �پ��� �ӵ�

    private float targetSpeed;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        targetSpeed = speed;
    }

    
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ);
        transform.Translate(move * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            targetSpeed = 20.0f; // Shift�� ������ ��ǥ �ӵ��� 20����
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            targetSpeed = 5.0f;
        }

        speed = Mathf.Lerp(speed, targetSpeed, Time.deltaTime * speedDecreaseRate);
    }
}
