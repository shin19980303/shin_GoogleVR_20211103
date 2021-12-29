using UnityEngine;
using UnityEngine.Events; //�ޥ� �ƥ� �R�W�Ŷ�

/// <summary>
/// VR���ʪ���
/// 1.VR�`���I�ݨ즹����Enter
/// 2.VR�`���I�ݨ�����}������Exit
/// 3.VR�`���I�ݨ즹������I�郎�ʫ���Click
/// </summary>

public class VRInteraction : MonoBehaviour
{
    [Header("�ƥ�:�ݨ�B���}�P�I��"), Space(10)]
    public UnityEvent onEnter;
    public UnityEvent onExit;
    public UnityEvent onClick;

    /// <summary>
    /// VR�`���I�ݨ즹����Enter
    /// </summary>
    public void OnPointerEnter()
    {
        onEnter.Invoke();
    }

    /// <summary>
    ///VR �`���I�ݨ�����}������Exit
    /// </summary>
    public void OnPointerExit()
    {
        onExit.Invoke();
    }

    /// <summary>
    /// VR�`���I�ݨ즹������I�郎�ʫ���Click
    /// </summary>
    public void OnPointerClick()
    {
        onClick.Invoke();
    }
}
