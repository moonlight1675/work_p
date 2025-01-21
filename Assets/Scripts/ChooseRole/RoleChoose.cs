using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleChoose : MonoBehaviour
{
    public int roleIndex = 0;//��ǰѡ��Ľ�ɫ���
    private Quaternion[] rolePlace;//ÿ����ɫ����תλ��
    // Start is called before the first frame update
    void Start()
    {
        // ��ʼ����ɫ��תλ��
        rolePlace = new Quaternion[]
        {
            Quaternion.Euler(0, 110, 0),       // JingLing����ת
            Quaternion.Euler(0, -147, 0),      // Female����ת
            Quaternion.Euler(0, -20, 0),     // Male����ת
        };
    }

    // Update is called once per frame
    void Update()
    {
        // ���¿ո���л���ɫ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            roleIndex = (roleIndex + 1) % rolePlace.Length; // ѭ���л���ɫ
        }

        // ƽ�����ɵ�Ŀ����ת
        transform.localRotation = Quaternion.Lerp(transform.localRotation, rolePlace[roleIndex], 0.05f);
    }
}
