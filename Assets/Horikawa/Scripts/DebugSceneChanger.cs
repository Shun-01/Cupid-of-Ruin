using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DebugSceneChanger : MonoBehaviour
{
    [SerializeField]
    string changeSceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C)) DebugSceneChange();
    }

    public void DebugSceneChange()
    {
        SceneManager.LoadScene(changeSceneName);
    }
}
