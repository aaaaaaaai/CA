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
        this.delta += Time.deltaTime; //�O�̃t���[���ƌ��݂̃t���[���̎��ԍ����o��
        if (this.delta > this.span)
        {
            //�P�a�����ɖ_�𐶐�����
            this.delta = 0;
            GameObject go = Instantiate(enemypre);

            //�����_���ȏꏊ�ɖ_��z�u����
            int px = Random.Range(-8, 8);
            go.transform.position = new Vector3(px, 6, 0);
        }
    }
}
