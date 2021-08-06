using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    public void ARScenePlants(){
        Debug.Log("Load new scene");
        SceneManager.LoadScene("ARScene");
    }
}
