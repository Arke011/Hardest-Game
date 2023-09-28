using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TP : MonoBehaviour
{
    public string nextLevelName;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Cube"))
        {
            SceneManager.LoadScene(nextLevelName);
            
        }
    }
}
