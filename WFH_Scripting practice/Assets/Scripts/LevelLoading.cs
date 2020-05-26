using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoading : MonoBehaviour
{
    // Start is called before the first frame update
    

    public void LoadObstacles()
    {
        SceneManager.LoadScene("Obstacle Course");
    }

    public void LoadFootball()
    {
        SceneManager.LoadScene("FootballLevel");
    }

    public void LoadTraps()
    {
        SceneManager.LoadScene("BoobyTraps");
    }
}
