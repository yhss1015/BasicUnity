using UnityEngine;

public class ConditionExample : MonoBehaviour
{
    //�����ڿ� ���ǹ�
    public int health = 100;


    void Start()
    {
        
        
    }

    
    void Update()
    {
        health -= 1; //ü�� ����
        Debug.Log("Health : " + health);

        //���ǹ�
        if(health<=0)
        {
            Debug.Log("Game Over!");
        }


    }
}
