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
                star += "★";
            }

            star += enter;
        }

        Debug.Log(star); //위에 작업 내용 한 번에 출력
    }

    public void Phase2()
    {
        int line = 5;
        string star = string.Empty;
        string enter = "\n";
        string space = "    ";


        for (int i = 0; i < line; i++) // 0~4까지 5회 반복
        {
            for (int j = 0; j < (line - 1) - i; j++) // j=jump(공백). 5-1-0=4회 찍기, 5-1-1=3회 찍기 ~ 0회 찍기까지
            {
                star += space; // 공백 넣기
            }

            for (int s = 0; s <= i; s++) //s=star(별찍기). 0~4까지 5회 반복
            {
                star += "★";
            }

            star += enter; //별 찍고 줄 바꾸기
        }

        Debug.Log(star); //위에 작업 내용 한 번에 출력
    }

    public void Phase3()
    {
        int line = 5;
        string star = string.Empty;
        string enter = "\n";
        string space = "    ";

        for (int i = 0; i < line; i++) // 0~4까지 5회 실행
        {
            for (int s = 0; s <= i; s++) 
            {
                star += "★";
            }

            star += enter;
        }

        for (int i = line; i > 0; i--) // 5~1까지 5번 실행
        {
            for (int s = 0; s < i-1; s++) //4~1까지 4번 실행
            {
                star += "★";
            }

            star += enter;

        }


        Debug.Log(star); //위에 작업 내용 한 번에 출력
    }

    public void Phase4()
    {
        int line = 5;
        string star = string.Empty;
        string enter = "\n";
        string space = "    ";


        for (int i = 0; i < line; i++) // 0~4까지 5회 반복
        {
            for (int j = 0; j < (line - 1) - i; j++) // j=jump(공백). 5-1-0=4회 찍기, 5-1-1=3회 찍기 ~ 0회 찍기까지
            {
                star += space; // 공백 넣기
            }

            for (int s = 0; s <= i; s++) //s=star(별찍기). 0~4까지 5회 반복
            {
                star += "★";
            }

            star += enter; //별 찍고 줄 바꾸기
        }

        for (int i = 0; i < line; i++) // 0~4까지 5회 반복
        {
            for (int j = 0; j <=i ; j++) // j=jump(공백). 0~4까지 5회 찍기
            {
                star += space; // 공백 넣기
            }

            for (int s = line-1; s > i; s--) //s=star(별찍기). 4~1까지 4회 반복
            {
                star += "★";
            }

            star += enter; //별 찍고 줄 바꾸기
        }


        Debug.Log(star); //위에 작업 내용 한 번에 출력
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
                star += space; // 공백 넣기
            }

            for(int s = 0; s <= (i*2); s++)
            {
                star += "★";
            }

            star += enter;
        }

        for (int i = line; i >= 1; i--) // 0~4까지 5회 반복
        {

            for (int j = 0; j < (line - i); j++)
            {
                star += space; // 공백 넣기
            }

            for(int s=1; s < 2*i; s++)
            {
                star += "★";
            }

            star += enter; //별 찍고 줄 바꾸기
        }

        Debug.Log(star); //위에 작업 내용 한 번에 출력
    }
}
