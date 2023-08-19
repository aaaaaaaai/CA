using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EGene : MonoBehaviour


{
    public GameObject enemypre;
    float span = 1.2f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime; //前のフレームと現在のフレームの時間差を出す
        if (this.delta > this.span)
        {
            //１病おきに棒を生成する
            this.delta = 0;
            GameObject go = Instantiate(enemypre);

            //ランダムな場所に棒を配置する
            int px = Random.Range(-8, 8);
            go.transform.position = new Vector3(px, 6, 0);
        }
    }
}
