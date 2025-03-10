using UnityEngine;

public class MoveWithGravity : MonoBehaviour
{
    public Rigidbody rb;

    public float speed = 5.0f;

    public float jumpForce = 5.0f; //��������

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Rigidbody : ����ȿ���� �߰��� �߷��� �����Ѵ�.
            //AddForce : ������ ���� ������Ʈ�� ���� �ش�.
            //ForceMode.Impulse : ���������� ���� ���ϴ� �ɼ��̴�.

            rb.AddForce(Vector3.up * jumpForce ,ForceMode.Impulse);
        }
    }
}
