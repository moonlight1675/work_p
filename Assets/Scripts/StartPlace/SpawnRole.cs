using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRole : MonoBehaviour
{
    public GameObject roleObject; // 用于所选角色的空父物体

    void Start()
    {
        // 从PlayerPrefs获取角色索引
        int roleIndex = PlayerPrefs.GetInt("SelectedRoleIndex");
        // 根据索引加载对应的预制体
        GameObject selectedPrefab = LoadPrefabByIndex(roleIndex);
        if (selectedPrefab != null)
        {
            // 实例化预制体
            GameObject instance = Instantiate(selectedPrefab, transform.position, Quaternion.identity);
            instance.name = selectedPrefab.name; // 可选：给实例化的对象命名
        }
    }

    GameObject LoadPrefabByIndex(int index)
    {
        //根据index获取对应的预制体名称
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
