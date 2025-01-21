using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement; // 引入场景管理命名空间
using UnityEngine.UI; // 引入 UI 命名空间（需要操作按钮）

public class SceneChanger : MonoBehaviour
{
    public GameObject role;//获取角色选取体
    private string targetSceneName= "StartPlace"; // 目标场景:序章
    // 通过按钮调用的方法
    public void ChangeScene()
    {
        // 保存角色索引到PlayerPrefs
        RoleChoose roleChoose = role.GetComponent<RoleChoose>();
        int index = roleChoose.roleIndex;
        PlayerPrefs.SetInt("SelectedRoleIndex", index);
        // 切换到目标场景
        SceneManager.LoadScene(targetSceneName);
    }
}