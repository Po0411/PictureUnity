using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

class Playr
{
    public void Play(string a)
    {
        Debug.Log(a);
    }
}

public class Start_ : MonoBehaviour
{
    void Start()
    {
        Debug.Log("����� Debug.Log���� Ȯ�� �Ѵ�.");

        int a = 10;
        float b = 3.14f;
        string name = "ȫ�浿";

        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(name);


        /*==================================================*/

        if(a < b)
        {
            Debug.Log("����");
        }
        else
        {
            Debug.Log("����");
        }

        /*==================================================*/

        for(int i = 2; i < 10; i++)
        {
            for(int j = 1; j < 10; j++)
            {
                Debug.Log(i + " * " + j + " = " + (i*j));
            }
        }

        /*==================================================*/

        add(10, 10);

        /*==================================================*/

        Playr playr = new Playr();

        playr.Play("���� ����");
    }

    void add(int a, int b)
    {
        Debug.Log(a + b);
    }

    void Update()
    {
        
    }
}
