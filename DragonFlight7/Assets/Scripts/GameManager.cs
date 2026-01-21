using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;
    private int Score {get;set;}

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void AddScore(int num)
    {
        Score += num;
        scoreText.text = "Score : " + Score;
    }



    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
