using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backLoader : MonoBehaviour
{
    public string backScene;

    public void LoadScene(){
        SceneManager.LoadScene(backScene);
    }
}
