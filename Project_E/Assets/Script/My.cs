using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class My : MonoBehaviour
{
    private string myname = "�̿���";
    private int age = 25;
    private float height = 161.5f;
    private string mbti = "INTJ";
    private string weight = "���";
    private string hobby1 = "�׸� �׸���";
    private string hobby2 = "�ǾƳ�";
    private string hobby3 = "�";
    private string sports1 = "�ǰܽ�����Ʈ";
    private string sports2 = "ȨƮ";


    void Start()
    {
        SelfIntroduction();
        SelfIntroduction(height, mbti);
        SelfIntroduction2();
    }

    public void SelfIntroduction()
    {
        Debug.Log("�� �̸���" + myname + "�Դϴ�.");
        Debug.Log($"���� ���̴�{age}�� �Դϴ�.");
    }

    public void SelfIntroduction(float _height, string _mbti)
    {
        Debug.Log("�� Ű��" + _height + "�Դϴ�.");
        Debug.Log($"�׸��� ���� �����ϴ� MBTI�� {_mbti} �Դϴ�.");
    }

    public void SelfIntroduction2()
    {
        Debug.Log("�� �����Դ� " + weight + "�Դϴ�.");
        Debug.Log($"���� �پ��� ��̰� �ִµ�, �ַ� {hobby1}�� {hobby2} ġ�� ���� �����մϴ�.");
        Debug.Log($"�� {hobby3}�� �����մϴ�.");
        Debug.Log($"���� ���� �����ϴ� {hobby3}�� {sports1}�̰�");
        Debug.Log($"���� ���� �����ϴ� {hobby3}�� {sports2}�Դϴ�.");
    }

    void Update()
    {

    }
}
