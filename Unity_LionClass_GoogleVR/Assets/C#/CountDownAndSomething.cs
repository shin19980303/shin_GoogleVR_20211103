using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// �˼ƭp��
/// �åB����{�Y��Ʊ�}
/// �Ҧp:���}�C���A���s�C���A��ܿ��...
/// </summary>
public class CountDownAndSomething : MonoBehaviour
{
    #region ���P�ݩ�
    [Header("�˼Ʈɶ�"), RangeAttribute(1, 5)]
    public float timeCountDown = 3;
    [Header("�˼ƫ�ƥ�")]
    public UnityEvent onTimeUp;
    [Header("����")]
    public Image imrBar;

    private float timeMax;

    /// <summary>
    /// �}�l�˼�:true�}�l�Bfalse����
    /// Unity Event �i�H�s��
    /// 1.���骫�� �s�����󤺪�API
    /// 2.�s����k�ȭ�: �L�Ϊ̤@�ӰѼơA�������������(������)
    /// 3.�s�����}�ݩ�:�������������(������)
    /// </summary>
    public bool startCountDown { get; set; }
    #endregion

    #region �˼ƥ\��
    //����ƥ�:�bStart�e����@��
    private void Awake()
    {
        timeMax = timeCountDown;
    }
    private void Update()
    {
        CountDown();
    }
    /// <summary>
    /// �p�ɾ�
    /// </summary>
    private float timer;

    /// <summary>
    /// �˼ƭp�ɥ\��
    /// </summary>
    private void CountDown()
    {
        if (startCountDown)                 //�p�G �}�l �˼�
        {
            if (timer < timeCountDown)      //�p�G �p�ɾ� �p�� �˼Ʈɶ�
            { 
                timer += Time.deltaTime;    //�֥[�ɶ�(��Update ���I�s)
            }
            else
            {
                onTimeUp.Invoke();          //�_�h �p�ɾ� �j��˩� �˼Ʈɶ� �N �I�s�ƥ�
            }

            imrBar.fillAmount = timer / timeMax; //���� = ��e�ɶ�/�̤j�ɶ�
        }
        else
        {
            timer = 0;
            imrBar.fillAmount = 0;
        }
    }
    #endregion
}
