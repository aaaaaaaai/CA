using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosubullet : MonoBehaviour
{
    public float shootDeley = 0.75f;
    public GameObject bossbulletpre;

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
            Instantiate(bossbulletpre, transform.position, Quaternion.identity);

            Invoke("StopAttack", shootDeley);

        }
        
    }

    public void shot() {
        Instantiate(bossbulletpre, transform.position, Quaternion.identity);

    }
    public void StopAttack()
    {
        inAttack = false;
    }
}