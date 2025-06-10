using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class My : MonoBehaviour
{
    private string myname = "이원림";
    private int age = 25;
    private float height = 161.5f;
    private string mbti = "INTJ";
    private string weight = "비밀";
    private string hobby1 = "그림 그리기";
    private string hobby2 = "피아노";
    private string hobby3 = "운동";
    private string sports1 = "피겨스케이트";
    private string sports2 = "홈트";


    void Start()
    {
        SelfIntroduction();
        SelfIntroduction(height, mbti);
        SelfIntroduction2();
    }

    public void SelfIntroduction()
    {
        Debug.Log("제 이름은" + myname + "입니다.");
        Debug.Log($"저의 나이는{age}살 입니다.");
    }

    public void SelfIntroduction(float _height, string _mbti)
    {
        Debug.Log("제 키는" + _height + "입니다.");
        Debug.Log($"그리고 요즘 유행하는 MBTI는 {_mbti} 입니다.");
    }

    public void SelfIntroduction2()
    {
        Debug.Log("제 몸무게는 " + weight + "입니다.");
        Debug.Log($"저는 다양한 취미가 있는데, 주로 {hobby1}와 {hobby2} 치는 것을 좋아합니다.");
        Debug.Log($"또 {hobby3}도 좋아합니다.");
        Debug.Log($"제가 제일 좋아하는 {hobby3}은 {sports1}이고");
        Debug.Log($"제가 제일 자주하는 {hobby3}은 {sports2}입니다.");
    }

    void Update()
    {

    }
}
