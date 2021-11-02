using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endScene : MonoBehaviour
{
    private BoxCollider2D col;
    public GameObject endingScene;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        endingScene.SetActive(false);
        col = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(this.tag == "flag")
        {
            //game end
            Debug.Log("end");
            Time.timeScale = 0;
            endingScene.SetActive(true);
        }
    }

    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
