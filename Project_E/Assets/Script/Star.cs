using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        int line = 5;
        string star = string.Empty;
        string enter = "\n";

        for (int i = 0; i < line; i++)
        {
            for(int j = 0; j<=i; j++)
            {
                star += "��";
            }

            star += enter;
        }

        Debug.Log(star); //���� �۾� ���� �� ���� ���
    }

    public void Phase2()
    {
        int line = 5;
        string star = string.Empty;
        string enter = "\n";
        string space = "    ";


        for (int i = 0; i < line; i++) // 0~4���� 5ȸ �ݺ�
        {
            for (int j = 0; j < (line - 1) - i; j++) // j=jump(����). 5-1-0=4ȸ ���, 5-1-1=3ȸ ��� ~ 0ȸ ������
            {
                star += space; // ���� �ֱ�
            }

            for (int s = 0; s <= i; s++) //s=star(�����). 0~4���� 5ȸ �ݺ�
            {
                star += "��";
            }

            star += enter; //�� ��� �� �ٲٱ�
        }

        Debug.Log(star); //���� �۾� ���� �� ���� ���
    }

    public void Phase3()
    {
        int line = 5;
        string star = string.Empty;
        string enter = "\n";
        string space = "    ";

        for (int i = 0; i < line; i++) // 0~4���� 5ȸ ����
        {
            for (int s = 0; s <= i; s++) 
            {
                star += "��";
            }

            star += enter;
        }

        for (int i = line; i > 0; i--) // 5~1���� 5�� ����
        {
            for (int s = 0; s < i-1; s++) //4~1���� 4�� ����
            {
                star += "��";
            }

            star += enter;

        }


        Debug.Log(star); //���� �۾� ���� �� ���� ���
    }

    public void Phase4()
    {
        int line = 5;
        string star = string.Empty;
        string enter = "\n";
        string space = "    ";


        for (int i = 0; i < line; i++) // 0~4���� 5ȸ �ݺ�
        {
            for (int j = 0; j < (line - 1) - i; j++) // j=jump(����). 5-1-0=4ȸ ���, 5-1-1=3ȸ ��� ~ 0ȸ ������
            {
                star += space; // ���� �ֱ�
            }

            for (int s = 0; s <= i; s++) //s=star(�����). 0~4���� 5ȸ �ݺ�
            {
                star += "��";
            }

            star += enter; //�� ��� �� �ٲٱ�
        }

        for (int i = 0; i < line; i++) // 0~4���� 5ȸ �ݺ�
        {
            for (int j = 0; j <=i ; j++) // j=jump(����). 0~4���� 5ȸ ���
            {
                star += space; // ���� �ֱ�
            }

            for (int s = line-1; s > i; s--) //s=star(�����). 4~1���� 4ȸ �ݺ�
            {
                star += "��";
            }

            star += enter; //�� ��� �� �ٲٱ�
        }


        Debug.Log(star); //���� �۾� ���� �� ���� ���
    }

    public void Phase5()
    {
        int line = 5;
        string star = string.Empty;
        string enter = "\n";
        string space = "    ";


        for (int i = 0; i < line -1; i++)
        {
            for(int j = 0; j< (line -1) -i; j++)
            {
                star += space; // ���� �ֱ�
            }

            for(int s = 0; s <= (i*2); s++)
            {
                star += "��";
            }

            star += enter;
        }

        for (int i = line; i >= 1; i--) // 0~4���� 5ȸ �ݺ�
        {

            for (int j = 0; j < (line - i); j++)
            {
                star += space; // ���� �ֱ�
            }

            for(int s=1; s < 2*i; s++)
            {
                star += "��";
            }

            star += enter; //�� ��� �� �ٲٱ�
        }

        Debug.Log(star); //���� �۾� ���� �� ���� ���
    }
}
