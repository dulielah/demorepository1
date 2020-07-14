using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScenesA : MonoBehaviour
//public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("LoadSceneA");
    }

    public void LoadA (string scenename)
    {
        Debug.Log("SampleScene" + scenename);
        SceneManager.LoadScene(scenename);
    }
}
