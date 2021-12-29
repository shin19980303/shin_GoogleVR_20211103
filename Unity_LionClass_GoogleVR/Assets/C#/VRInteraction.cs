using UnityEngine;
using UnityEngine.Events; //引用 事件 命名空間

/// <summary>
/// VR互動物件
/// 1.VR注視點看到此物件Enter
/// 2.VR注視點看到後離開此物件Exit
/// 3.VR注視點看到此物件並點選互動按紐Click
/// </summary>

public class VRInteraction : MonoBehaviour
{
    [Header("事件:看到、離開與點擊"), Space(10)]
    public UnityEvent onEnter;
    public UnityEvent onExit;
    public UnityEvent onClick;

    /// <summary>
    /// VR注視點看到此物件Enter
    /// </summary>
    public void OnPointerEnter()
    {
        onEnter.Invoke();
    }

    /// <summary>
    ///VR 注視點看到後離開此物件Exit
    /// </summary>
    public void OnPointerExit()
    {
        onExit.Invoke();
    }

    /// <summary>
    /// VR注視點看到此物件並點選互動按紐Click
    /// </summary>
    public void OnPointerClick()
    {
        onClick.Invoke();
    }
}
