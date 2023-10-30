using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRStartButtonControl : MonoBehaviour
{
    public Canvas canvas; // Start 버튼을 눌렀을 때 활성화 또는 비활성화할 Canvas

    private void Start()
    {
        if (canvas != null)
        {
            canvas.enabled = false; // 게임 시작 시 Canvas를 비활성화
        }
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Start)) // Oculus Start 버튼이 눌렸을 때
        {
            if (canvas != null)
            {
                canvas.enabled = !canvas.enabled; // Canvas의 활성화 상태를 토글합니다.
            }
        }
    }
}