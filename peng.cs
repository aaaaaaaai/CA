using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peng : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().Play("pengin");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
