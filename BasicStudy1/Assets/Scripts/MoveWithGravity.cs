using UnityEngine;

public class MoveWithGravity : MonoBehaviour
{
    public Rigidbody rb;

    public float speed = 5.0f;

    public float jumpForce = 5.0f; //점프힘ㅁ

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Rigidbody : 물리효과를 추가해 중력을 적용한다.
            //AddForce : 점프를 위해 오브젝트에 힘을 준다.
            //ForceMode.Impulse : 순간적으로 힘을 가하는 옵션이다.

            rb.AddForce(Vector3.up * jumpForce ,ForceMode.Impulse);
        }
    }
}
