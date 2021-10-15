using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchTOMain : MonoBehaviour
{
    public Button backBtn;
    public string SceneName="FirstScene";
    // Start is called before the first frame update
    void Start()
    {
        backBtn.onClick.AddListener(BackToMain);
    }
    public void BackToMain(){
        SceneManager.LoadScene(SceneName);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
