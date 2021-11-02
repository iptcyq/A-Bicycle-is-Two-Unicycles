using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    public GameObject credits;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N)) { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); } //make sure next scene is of 1 build index more :)
        if (Input.GetKeyDown(KeyCode.M)) { SceneManager.LoadScene("Menu"); }


        if (SceneManager.GetActiveScene().name == "Level4")
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                credits.SetActive(true);
            }
        }
    }
}
