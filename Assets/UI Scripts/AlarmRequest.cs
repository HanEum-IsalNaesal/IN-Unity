using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AlarmRequest : MonoBehaviour
{
    public Button button_yes;
    public Button button_no;

    public TextMeshProUGUI text_friendid;

    public System.Action<string> onClickYesFriend;
    public System.Action<string> onClickNoFriend;

    string friendid = "kim";

    private void Awake()
    {
     
        this.button_yes.onClick.AddListener(() =>
        {
            Debug.LogFormat("requestfriendid: {0}, yes", friendid);

            this.onClickYesFriend(friendid);
        });

        this.button_no.onClick.AddListener(() =>
        {
            Debug.LogFormat("requestfriendid: {0},no", friendid);

            this.onClickNoFriend(friendid);
        });
    }

    void Start()
    {
        text_friendid.text = friendid;
    }

}