using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void start() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        

    }

    public void restart() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("startscene");
        EnemyController.killcount = 0;
    }
    
}
