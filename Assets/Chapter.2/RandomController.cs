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
                TexOut.text = "정답입니다! 숫자는 " + generatedValue + "입니다.";
            }
            else
            {
                TexOut.text = "다시 시도해 보세요! 정답은 " + generatedValue + "입니다.";
            }
        }
        else
        {
            TexOut.text = "유효한 숫자를 입력해 주세요.";
        }
    }
}
