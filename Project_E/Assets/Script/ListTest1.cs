using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ListTest1 : MonoBehaviour
{
    List<string> characterList = new List<string>();

    int n;

    public void Gacha() // characterList 0 ~ 9 -> �� 10��
    {
        characterList.Add("������"); // 0��
        characterList.Add("�ǵ���"); // 1��
        characterList.Add("�ǿ���"); // 2��
        characterList.Add("����"); // 3��
        characterList.Add("��ͷ�"); // 4��
        characterList.Add("�赵��"); // 5��
        characterList.Add("��ο�"); // 6��
        characterList.Add("�����"); // 7��
        characterList.Add("�輺��"); // 8��
        characterList.Add("�迹��"); // 9��
        characterList.Add("������");
        characterList.Add("������");
        characterList.Add("������");
        characterList.Add("������");
        characterList.Add("���ѳ�");
        characterList.Add("��ν�");
        characterList.Add("���ȯ");
        characterList.Add("������");
        characterList.Add("�μ���");
        characterList.Add("�ڰ���");
        characterList.Add("�ڹμ�");
        characterList.Add("�ڼ���");
        characterList.Add("�ڽÿ�");
        characterList.Add("�����");
        characterList.Add("����ȯ");
        characterList.Add("���ؼ�");
        characterList.Add("������");
        characterList.Add("������");
        characterList.Add("�����");
        characterList.Add("�����");
        characterList.Add("�ռ���");
        characterList.Add("�ż���");
        characterList.Add("�Ž�ȯ");
        characterList.Add("��ä��");
        characterList.Add("����ȯ");
        characterList.Add("���ȭ");
        characterList.Add("������");
        characterList.Add("������");
        characterList.Add("���뿬");
        characterList.Add("���߿�");
        characterList.Add("���繫��");
        characterList.Add("�̰���");
        characterList.Add("�̰��");
        characterList.Add("�̱���");
        characterList.Add("�̵���");
        characterList.Add("�̹�ȣ");
        characterList.Add("�̻��");
        characterList.Add("�̻�");
        characterList.Add("�̼���");
        characterList.Add("�̽���");
        characterList.Add("�̿���");
        characterList.Add("������");
        characterList.Add("����ȣ");
        characterList.Add("���ظ�");
        characterList.Add("��âȣ");
        characterList.Add("��ä��");
        characterList.Add("��ȣ��");
        characterList.Add("����ȣ");
        characterList.Add("���¿�");
        characterList.Add("������");
        characterList.Add("��ȣ��");
        characterList.Add("������");
        characterList.Add("���ν�");
        characterList.Add("������");
        characterList.Add("���ο�");
        characterList.Add("������");
        characterList.Add("������");
        characterList.Add("������");
        characterList.Add("õ����");
        characterList.Add("�ֹ���");
        characterList.Add("������");
        characterList.Add("�Ѽ���");
        characterList.Add("���翵");
        characterList.Add("ȫ����");


        for (int i = 0; i<1; i++) //1ȸ �ݺ��Ͽ� �̱� ���
        {
            int rand = Random.Range(0,characterList.Count); //rand ������ ���� 0���� characterList�� ���� �� ���� ���
            print(characterList[rand]);
            characterList.RemoveAt(rand); // �� ����� �ٽ� �ݺ�
        }


    }

    /*
    private void start()
    {
        int randomValue = Random.Range(0, 9); // 0~9���� �� 10�� �� ���� ���

        for (int n = 1; n < 11; n++)
        {
            Debug.Log(n + "��° �л� ĳ���ʹ�" + characterList[randomValue] + "�� ĳ���� �Դϴ�.");
        }
    }
    */

}