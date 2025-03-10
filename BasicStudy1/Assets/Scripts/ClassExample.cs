using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class Player
{
    public string name;
    public int score;

    public Player(string playerName,int playerScore)
    {
        name = playerName;
        score = playerScore;
    }

    public void ShowInfo()
    {
        Debug.Log("Player : " + name + ", Score : " + score);
    }
}


public class ClassExample : MonoBehaviour
{

    public Player player;

    void Start()
    {
        player = new Player("Hero", 10);
        player.ShowInfo();
    }

    
    void Update()
    {
        
    }
}
