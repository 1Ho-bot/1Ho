using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardSettings : MonoBehaviour
{

    public string fieldSkill = "�� �� ���� �����Ͽ� 10�� �������� �ְ� ��ġ�� �ִ� �Ʊ��� ü���� 10ȸ�� ��Ų��.";
    public string benchSkill = "�Ʊ� �� ���� �����Ͽ� ü���� 5ȸ�� ��Ų��.";

    private GameObject inforText;

    // Start is called before the first frame update
    void Start()
    {
        inforText = GameObject.Find("Parchment").transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseDown()
    {
        inforText.GetComponent<SkillText>().Infor(fieldSkill, benchSkill);
        Debug.Log("�̹��� Ŭ�� �����.");
    }
}
