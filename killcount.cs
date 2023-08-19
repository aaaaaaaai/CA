using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class killcount : MonoBehaviour
{
    GameObject KillCOUNT;
    // Start is called before the first frame update
    void Start()
    {
        this.KillCOUNT = GameObject.Find("killc");
        this.KillCOUNT.GetComponent<TextMeshProUGUI>().text = "kill:" + EnemyController.killcount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
