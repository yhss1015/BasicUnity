using UnityEngine;
using UnityEngine.InputSystem;

public class MoveObject : MonoBehaviour
{

    public float speed = 5.0f; //�̵��ӵ�
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
        // Ű �Է¿� ���� �̵�
        float move = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * move * speed * Time.deltaTime);
    }
}
