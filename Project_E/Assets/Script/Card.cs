using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardGrade { S, A, B, C } //ī�� ��� ������

[System.Serializable]
public class Card : MonoBehaviour
{
    public string cardName; //ī�� �̸�
    public Sprite cardImage; //ī�� �̹���
    public CardGrade cardGrad; //ī�� ���

    public int weight; //��� ����ġ ǥ

    public Card(Card card) //ī�� Ŭ����. ī�带 �޾� ���� ī�� �ʱ�ȭ
    {
        this.cardName = card.cardName;
        this.cardImage = card.cardImage;
        this.cardGrad = card.cardGrad;
        this.weight = card.weight;
    }


}
