using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRStartButtonControl : MonoBehaviour
{
    public Canvas canvas; // Start ��ư�� ������ �� Ȱ��ȭ �Ǵ� ��Ȱ��ȭ�� Canvas

    private void Start()
    {
        if (canvas != null)
        {
            canvas.enabled = false; // ���� ���� �� Canvas�� ��Ȱ��ȭ
        }
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Start)) // Oculus Start ��ư�� ������ ��
        {
            if (canvas != null)
            {
                canvas.enabled = !canvas.enabled; // Canvas�� Ȱ��ȭ ���¸� ����մϴ�.
            }
        }
    }
}