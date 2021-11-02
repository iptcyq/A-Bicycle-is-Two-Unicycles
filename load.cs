using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour
{
    public float time = 5f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Menu");
    }
}
