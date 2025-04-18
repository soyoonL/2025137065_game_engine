using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelObject : MonoBehaviour
{
    public string nextLevel;

    // Start is called before the first frame update
    public void MoveToNextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
