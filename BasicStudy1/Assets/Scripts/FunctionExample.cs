using UnityEngine;


public class FunctionExample : MonoBehaviour
{
    //�Լ� ����
    void SayHello()
    {
        Debug.Log("Hello Unity");
    }

    int AddNumbers(int a,int b)
    {
        return a+b;
    }

    
    void Start()
    {
        SayHello(); //�Լ�ȣ��
        int total = AddNumbers(3, 5);
        Debug.Log("Total : " + total);
    }

    
    void Update()
    {
        
    }
}
