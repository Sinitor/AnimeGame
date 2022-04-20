using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float check1;
    public static float check2;
    public static float check3;
    public static float check4;
    public static float check5;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public TextMeshProUGUI text4;
    public TextMeshProUGUI text5;
    public GameObject checker1;
    public GameObject checker2;
    public GameObject checker3;
    public GameObject checker4;
    public GameObject checker5;
    public GameObject mono1;
    public GameObject mono2;
    public GameObject mono3; 

    public static float adRemake;
    public Image ADS;
         
    private void Start()
    {
        adRemake = 5;
        check1 = 999f;
        check2 = 999f;
        check3 = 999f;
        check4 = 999f;
        check5 = 999f;
        Cursor.visible = false;
    }
    private void Update()
    {
        text1.text = "" + check1;
        text2.text = "" + check2;
        text3.text = "" + check3;
        text4.text = "" + check4;
        text5.text = "" + check5;
        Destroy();
        if (checker1 == null && checker2 == null && checker3 == null && checker4 == null && checker5 == null)
        {
            Destroy(mono1);
            Destroy(mono2);
            Destroy(mono3);
        }
        if (adRemake <= 0)
        {
            Time.timeScale = 0;
            Cursor.visible = true;
            ADS.gameObject.SetActive(true);
        }
    } 
    public void OnADS()
    {
        adRemake = 5;
        ADS.gameObject.SetActive(false);
    }
    private void Destroy()
    {
        if (check1 <= 0)
        {
            Destroy(checker1);
        }
        if (check2 <= 0)
        {
            Destroy(checker2);
        }
        if (check3 <= 0)
        {
            Destroy(checker3);
        }
        if (check4 <= 0)
        {
            Destroy(checker4);
        }
        if (check5 <= 0)
        {
            Destroy(checker5);
        }
    }
}
