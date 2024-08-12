using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class RandomController : MonoBehaviour
{
    public InputField InputOut;
    public Text TexOut;
    int Random_ = 0;

    void Start()
    {
        Random_ = (int)Random.Range(0, 100);
        Debug.Log(Random_);

        judgment(Random_);
    }

    public void judgment(int generatedValue)
    {
        if (int.TryParse(InputOut.text, out int userValue))
        {
            if (generatedValue == userValue)
            {
                TexOut.text = "�����Դϴ�! ���ڴ� " + generatedValue + "�Դϴ�.";
            }
            else
            {
                TexOut.text = "�ٽ� �õ��� ������! ������ " + generatedValue + "�Դϴ�.";
            }
        }
        else
        {
            TexOut.text = "��ȿ�� ���ڸ� �Է��� �ּ���.";
        }
    }
}
