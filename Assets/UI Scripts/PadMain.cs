using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PadMain : MonoBehaviour
{
    public Button button_open_social;
    public PadSocial padsocial;

    public Button button_open_alarm;
    public PadAlarm padalarm;

    public Button button_open_sound;
    public PadSound padsound;

    public Button button_exit;


    public PadSocial padSocial;

    public void Init()
    {
        this.padsocial.button_close.onClick.AddListener(() => {
            this.padsocial.Close();
        });

        this.button_open_social.onClick.AddListener(() => {
            this.padsocial.Open();
        });

        this.padalarm.button_close.onClick.AddListener(() => {
            this.padalarm.Close();
        });

        this.button_open_alarm.onClick.AddListener(() => {
            this.padalarm.Open();
        });

        this.padsound.button_close.onClick.AddListener(() => {
            this.padsound.Close();
        });

        this.button_open_sound.onClick.AddListener(() => {
            this.padsound.Open();
        });
    }

    // Start is called before the first frame update
        void Start()
    {
        this.padsocial.onClickSearchFriend = (friendid) =>
        {
            Debug.LogFormat("friendid: {0}",friendid);
        };
    }

    // Update is called once per frame
        void Update()
    {

    }
}
