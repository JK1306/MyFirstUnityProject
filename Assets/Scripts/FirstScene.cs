using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstScene : MonoBehaviour
{
    public Button button1,button2,button3;
    public string Scene1,Scene2,Scene3;
    // Start is called before the first frame update
    void Start()
    {
        button1.onClick.AddListener(LoadScene1);
        button2.onClick.AddListener(LoadScene2);
        button3.onClick.AddListener(LoadScene3);
    }

    private void LoadScene1(){
        SceneManager.LoadScene(Scene1);
    }

    private void LoadScene2(){
        SceneManager.LoadScene(Scene2);
    }
    private void LoadScene3(){
        SceneManager.LoadScene(Scene3);
    }

    void Update()
    {
        
    }
}
