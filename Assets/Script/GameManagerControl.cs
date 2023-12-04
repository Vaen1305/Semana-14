using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerControl : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            SceneManager.LoadScene("PrimerNivel");
        }
    }
}
