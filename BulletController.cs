using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject bullet;
    public float Bulletspeed = 7.0f ;
    public float deleteTime = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, deleteTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, Bulletspeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            bullet.SetActive(false);
            //接触したゲームオブジェクトの子要素にする
            transform.SetParent(collision.transform);
            //当たり判定を無効化
            GetComponent<CircleCollider2D>().enabled = false;
            //物理エンジンを無効化
            GetComponent<Rigidbody2D>().simulated = false;

        }

        if (collision.CompareTag("boss"))
        {
            bullet.SetActive(false);
            //接触したゲームオブジェクトの子要素にする
            transform.SetParent(collision.transform);
            //当たり判定を無効化
            GetComponent<CircleCollider2D>().enabled = false;
            //物理エンジンを無効化
            GetComponent<Rigidbody2D>().simulated = false;

        }
    }
}
