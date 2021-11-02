using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject credits;
    private bool on = false;

    public TextMeshProUGUI text;
    public float timer = 20f;
    private bool activated = true;

    // Start is called before the first frame update
    void Start()
    {
        activated = true;
        credits.SetActive(false);
        on = false;
        if (SceneManager.GetActiveScene().name == "Menu" || SceneManager.GetActiveScene().name == "Level4"|| SceneManager.GetActiveScene().name == "Level2")
        {
            FindObjectOfType<audioManager>().Play("theme2");
        }
        else if (SceneManager.GetActiveScene().name == "Tutorial" || SceneManager.GetActiveScene().name == "Level3" || SceneManager.GetActiveScene().name == "Level1")
        {
            FindObjectOfType<audioManager>().Play("theme1");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Menu")
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                SceneManager.LoadScene("Level1");
            }
            if (Input.GetKeyDown(KeyCode.T)) {
                SceneManager.LoadScene("Tutorial");

            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                on = !on;
                credits.SetActive(on);
            }
        }

        if(SceneManager.GetActiveScene().name == "Level2")
        {
            text.text = timer.ToString();
            if (activated)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    timer = 0.0f; activated = false;
                }
            }
        }

    }

    public void SwitchScenes(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    
}
