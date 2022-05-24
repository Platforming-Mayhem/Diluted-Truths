using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimedChangeScene : MonoBehaviour
{
    public float time = 1.0f;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time > 0.0f)
        {
            time -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
