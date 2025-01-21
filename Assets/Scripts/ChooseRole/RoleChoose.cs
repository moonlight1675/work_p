using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleChoose : MonoBehaviour
{
    public int roleIndex = 0;//当前选择的角色序号
    private Quaternion[] rolePlace;//每个角色的旋转位置
    // Start is called before the first frame update
    void Start()
    {
        // 初始化角色旋转位置
        rolePlace = new Quaternion[]
        {
            Quaternion.Euler(0, 110, 0),       // JingLing的旋转
            Quaternion.Euler(0, -147, 0),      // Female的旋转
            Quaternion.Euler(0, -20, 0),     // Male的旋转
        };
    }

    // Update is called once per frame
    void Update()
    {
        // 按下空格键切换角色
        if (Input.GetKeyDown(KeyCode.Space))
        {
            roleIndex = (roleIndex + 1) % rolePlace.Length; // 循环切换角色
        }

        // 平滑过渡到目标旋转
        transform.localRotation = Quaternion.Lerp(transform.localRotation, rolePlace[roleIndex], 0.05f);
    }
}
