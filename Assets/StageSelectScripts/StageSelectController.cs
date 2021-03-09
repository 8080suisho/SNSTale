using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToTutorial()
    {
        Debug.Log("押されました");
        SceneManager.LoadScene("Tutorial");
    }

    public void ToTomomi()
    {
        SceneManager.LoadScene("Main");
    }

    public void ToTencho()
    {
        SceneManager.LoadScene("Main2");
    }
}
