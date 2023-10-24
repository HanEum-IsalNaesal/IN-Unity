using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MyFriendList : MonoBehaviour
{
    public GameObject myfriendimage1;
    public GameObject myfriendimage2;
    public GameObject myfriendimage3;
    public GameObject myfriendimage4;
    public GameObject myfriendimage5;
    public GameObject myfriendimage6;
    public GameObject myfriendimage7;
    public GameObject myfriendimage8;

    public TextMeshProUGUI myfriend1;
    public TextMeshProUGUI myfriend2;
    public TextMeshProUGUI myfriend3;
    public TextMeshProUGUI myfriend4;
    public TextMeshProUGUI myfriend5;
    public TextMeshProUGUI myfriend6;
    public TextMeshProUGUI myfriend7;
    public TextMeshProUGUI myfriend8;

    string[] myfriendlist = { "a", "b", "c", "d", "e" };

    void Start()

    {
        //myfriendimage1 = GameObject.Find("myfriend1");
        //myfriendimage2 = GameObject.Find("myfriend2");
        //myfriendimage3 = GameObject.Find("myfriend3");
        //myfriendimage4 = GameObject.Find("myfriend4");
        //myfriendimage5 = GameObject.Find("myfriend5");
        //myfriendimage6 = GameObject.Find("myfriend6");
        //myfriendimage7 = GameObject.Find("myfriend7");
        //myfriendimage8 = GameObject.Find("myfriend8");

        int i = myfriendlist.Length;

        if (i > 0)
        {
            myfriendimage1.SetActive(true);
            myfriend1.text = myfriendlist[0];
        }
        if (i > 1)
        {
            myfriendimage2.SetActive(true);
            myfriend2.text = myfriendlist[1];
        }
        if (i > 2)
        {
            myfriendimage3.SetActive(true);
            myfriend3.text = myfriendlist[2];
        }
        if (i > 3)
        {
            myfriendimage4.SetActive(true);
            myfriend4.text = myfriendlist[3];
        }
        if (i > 4)
        {
            myfriendimage5.SetActive(true);
            myfriend5.text = myfriendlist[4];
        }
        if (i > 5)
        {
            myfriendimage6.SetActive(true);
            myfriend6.text = myfriendlist[5];
        }
        if (i > 6)
        {
            myfriendimage7.SetActive(true);
            myfriend7.text = myfriendlist[6];
        }
        if (i > 7)
        {
            myfriendimage8.SetActive(true);
            myfriend8.text = myfriendlist[7];
        }
    }
}