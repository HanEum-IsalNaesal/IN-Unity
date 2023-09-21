using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Canvas_Log canvas_log;

    public Canvas_Sign canvas_sign;

    void Start()
    {
        this.canvas_log.onClickLogin = (id, password) =>
        {
            Debug.LogFormat("id: {0}, password: {1}", id, password);
        };

        this.canvas_sign.onClickSignup = (id, password, name) =>
        {
            Debug.LogFormat("id: {0}, password: {1}, name: {2}", id, password, name);
        };

    }

    void Update()
    {
        
    }
}
