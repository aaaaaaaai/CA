using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletshooter : MonoBehaviour
{
    public float shootSpeed = 12.0f;
    public float shootDeley = 0.55f;
    public GameObject bulletpre;

    bool inAttack = false;
    Vector3 hassyaiti;

    // Start is called before the first frame update
    void Start()
    {
        hassyaiti = transform.Find("bulletpos").localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }

    public void Attack()
    {
        //çUåÇíÜÇ≈Ç»Ç¢
        if (inAttack == false)
        {
            inAttack = true;
            Instantiate(bulletpre, transform.position + hassyaiti, Quaternion.identity);

            Invoke("StopAttack", shootDeley);
        }
    }

    public void StopAttack()
    {
        inAttack = false;
    }
}
