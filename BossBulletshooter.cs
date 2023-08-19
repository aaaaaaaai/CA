using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletshooter : MonoBehaviour
{
    public float bossshootspeed = 10.0f;
    public float shootSpeed = 12.0f;
    public float bossshootdeley = 3.0f;
    public float shootDeley = 10.0f;
    public GameObject bulletpre;

    bool inAttack = false;

    // Start is called before the first frame update
    void Start()
    {
        
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
            Instantiate(bulletpre, transform.position, Quaternion.identity);

            Invoke("StopAttack", bossshootdeley);
        }
    }

    public void StopAttack()
    {
        inAttack = false;
    }
}