using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRole : MonoBehaviour
{
    public GameObject roleObject; // ������ѡ��ɫ�Ŀո�����

    void Start()
    {
        // ��PlayerPrefs��ȡ��ɫ����
        int roleIndex = PlayerPrefs.GetInt("SelectedRoleIndex");
        // �����������ض�Ӧ��Ԥ����
        GameObject selectedPrefab = LoadPrefabByIndex(roleIndex);
        if (selectedPrefab != null)
        {
            // ʵ����Ԥ����
            GameObject instance = Instantiate(selectedPrefab, transform.position, Quaternion.identity);
            instance.name = selectedPrefab.name; // ��ѡ����ʵ�����Ķ�������
        }
    }

    GameObject LoadPrefabByIndex(int index)
    {
        //����index��ȡ��Ӧ��Ԥ��������
        string prefabName = "JingLing";
        if (index == 1)
        {
            prefabName = "Female";
        }
        else if (index==2)
        {
            prefabName = "Male";
        }
        GameObject prefab = Resources.Load<GameObject>(prefabName);
        return prefab;
    }
}
