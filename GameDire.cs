using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDire : MonoBehaviour
{
    GameObject HPGauge;
    GameObject HPGauge1;
    GameObject HPGauge2;
    public GameObject boss;
    public GameObject bossHP;
    GameObject Killcount;
    public GameObject hpbar;
    public GameObject blogo;

    // Start is called before the first frame update
    void Start()
    {
        this.HPGauge = GameObject.Find("HPgauge");
        this.HPGauge1 = GameObject.Find("HPgauge1");
        this.HPGauge2 = GameObject.Find("HPgauge2");
        this.Killcount = GameObject.Find("KILLcount");

    }

    private void Update()
    {
        bossdasu();

        this.Killcount.GetComponent<TextMeshProUGUI>().text = "kill:" + EnemyController.killcount;
    }

    public void DecreaseHP()
    {
        if (this.HPGauge.GetComponent<Image>().fillAmount > 0f)
        {
            //当たったときにHPゲージを減らす処理
            this.HPGauge.GetComponent<Image>().fillAmount -= 0.5f;
        }
        else if (this.HPGauge1.GetComponent<Image>().fillAmount > 0f)
        {
            this.HPGauge1.GetComponent<Image>().fillAmount -= 0.5f;
        }
        else if (this.HPGauge2.GetComponent<Image>().fillAmount > 0f) {
            this.HPGauge2.GetComponent<Image>().fillAmount -= 0.5f;
        } else { 
        }

        if (this.HPGauge2.GetComponent<Image>().fillAmount <= 0f) {
           
            UnityEngine.SceneManagement.SceneManager.LoadScene("gameover");
        }
    }

    public void DecreaseHP1()
    {
        if (this.HPGauge.GetComponent<Image>().fillAmount > 0f)
        {
            //当たったときにHPゲージを減らす処理
            this.HPGauge.GetComponent<Image>().fillAmount -= 1f;
        }
        else if (this.HPGauge1.GetComponent<Image>().fillAmount > 0f)
        {
            this.HPGauge1.GetComponent<Image>().fillAmount -= 1f;
        }
        else if (this.HPGauge2.GetComponent<Image>().fillAmount > 0f)
        {
            this.HPGauge2.GetComponent<Image>().fillAmount -= 1f;
        }
        else
        {
        }

        if (this.HPGauge2.GetComponent<Image>().fillAmount <= 0f)
        {
           
            UnityEngine.SceneManagement.SceneManager.LoadScene("gameover");
        }
    }

    public void bossDecreaseHP()
    {
        
            this.hpbar.GetComponent<Image>().fillAmount -= 0.01f;
        if (this.hpbar.GetComponent<Image>().fillAmount <= 0f)
        {
 
        }
    }

 

    public void bossdasu() {
        if (EnemyController.killcount >= 41)
        {
            blogo.SetActive(true);
            boss.SetActive(true);
            bossHP.SetActive(true);
            Destroy(blogo, 1f);
        }
        else { 
        
        }
    }

    public void logo() { 
        blogo.SetActive(false);
    }
}