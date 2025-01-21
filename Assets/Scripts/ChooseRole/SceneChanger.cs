using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement; // ���볡�����������ռ�
using UnityEngine.UI; // ���� UI �����ռ䣨��Ҫ������ť��

public class SceneChanger : MonoBehaviour
{
    public GameObject role;//��ȡ��ɫѡȡ��
    private string targetSceneName= "StartPlace"; // Ŀ�곡��:����
    // ͨ����ť���õķ���
    public void ChangeScene()
    {
        // �����ɫ������PlayerPrefs
        RoleChoose roleChoose = role.GetComponent<RoleChoose>();
        int index = roleChoose.roleIndex;
        PlayerPrefs.SetInt("SelectedRoleIndex", index);
        // �л���Ŀ�곡��
        SceneManager.LoadScene(targetSceneName);
    }
}