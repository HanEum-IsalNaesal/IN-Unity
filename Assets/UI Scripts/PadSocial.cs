using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PadSocial: MonoBehaviour
{
    public Button button_close;

    public void Init()
    {

    }

    public void Open()
    {
        this.gameObject.SetActive(true);
    }

    public void Close()
    {
        this.gameObject.SetActive(false);
    }

    public TMP_InputField inputFriendId;
    public Button btnSearchFriend;
    public System.Action<string> onClickSearchFriend;

    private void Awake()
    {
        this.btnSearchFriend.onClick.AddListener(() =>
        {
            string friendid = this.inputFriendId.text;
            Debug.LogFormat("friendid: {0}", friendid);

            this.onClickSearchFriend(friendid);
        });
    }

    void Start()
    {
        
    }
}