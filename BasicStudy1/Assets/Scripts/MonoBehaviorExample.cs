using UnityEngine;

public class MonoBehaviorExample : MonoBehaviour
{
    
    void Start()
    {
        Debug.Log("Start: ������ ���۵� �� ȣ��˴ϴ�.");
    }

    
    void Update()
    {
        Debug.Log("Update : �����Ӹ��� ȣ��˴ϴ�.");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate : ���� ���꿡 ���˴ϴ�.");
    }

    //��Ʈ�� ����Ʈ m

}
