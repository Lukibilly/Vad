using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onboardingmanager : MonoBehaviour
{
    public void goToMainMenu(){
        Debug.Log("Load new scene");
        SceneManager.LoadScene("ARScene");
    }
}
