using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_firstscene : MonoBehaviour
{
    public Button button_openlog;
    public Canvas_Log canvas_Log;

    public Button button_opensign;
    public Canvas_Sign canvas_Sign;

    public void Init()
    {
        this.canvas_Log.button_close.onClick.AddListener(() => {
            this.canvas_Log.Close();
        });

        this.button_openlog.onClick.AddListener(() => {
            this.canvas_Log.Open();
        });

        this.canvas_Sign.button_close.onClick.AddListener(() => {
            this.canvas_Sign.Close();
        });

        this.button_opensign.onClick.AddListener(() => {
            this.canvas_Sign.Open();
        });
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
