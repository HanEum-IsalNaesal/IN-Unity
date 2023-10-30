using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class StartButtonControl : MonoBehaviour
{
    //public Button button_open_pad;
    public GameObject uiPanel;
    private bool isPanelActive = false;

    void Start()
    {
        // 초기에 UI 패널 비활성화
        uiPanel.SetActive(false);
    }

    public void TogglePanel()
    {
        // 버튼 클릭 시 호출되는 함수
        isPanelActive = !isPanelActive; // 현재 상태를 반대로 변경

        // UI 패널 활성화/비활성화
        uiPanel.SetActive(isPanelActive);
    }
}