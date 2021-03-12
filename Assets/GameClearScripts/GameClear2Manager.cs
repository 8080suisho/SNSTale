using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear2Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RePlay()
    {
        SceneManager.LoadScene("Main2");
    }

    public void ToStageSelect()
    {
        SceneManager.LoadScene("StageSelect");
    }
}
