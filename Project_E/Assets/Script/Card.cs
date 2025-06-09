using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardGrade { S, A, B, C } //카드 등급 열거형

[System.Serializable]
public class Card : MonoBehaviour
{
    public string cardName; //카드 이름
    public Sprite cardImage; //카드 이미지
    public CardGrade cardGrad; //카드 등급

    public int weight; //등급 가중치 표

    public Card(Card card) //카드 클래스. 카드를 받아 현재 카드 초기화
    {
        this.cardName = card.cardName;
        this.cardImage = card.cardImage;
        this.cardGrad = card.cardGrad;
        this.weight = card.weight;
    }


}
