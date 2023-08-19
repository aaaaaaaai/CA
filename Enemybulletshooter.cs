using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemybulletshooter : MonoBehaviour
{
    public float shootSpeed = 12.0f;
    public float shootDeley = 3.00f;
    public GameObject bulletpre;

    bool inAttack = false;
    Vector3 hassyaiti;

    // Start is called before the first frame update
    void Start()
    {
        hassyaiti = transform.Find("bulletposi").localPosition;
    }

    // Update is called once per frame
    void Update()
    {    
            Attack();
    }

    public void Attack()
    {
        //çUåÇíÜÇ≈Ç»Ç¢
        if (inAttack == false)
        {
            inAttack = true;
            Instantiate(bulletpre, transform.position + hassyaiti, Quaternion.identity);

            Invoke("StopAttack", shootDeley);
            GameObject director = GameObject.Find("GameObject1");
            director.GetComponent<sound1>().Se1();
        }
    }

    public void StopAttack()
    {
        inAttack = false;
    }
}
