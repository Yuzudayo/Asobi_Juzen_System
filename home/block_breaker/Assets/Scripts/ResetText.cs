using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Text�R���|�[�l���g���g�p����ꍇ�ɕK�v
using UnityEngine.UI;

public class ResetText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�A�N�Z�X�͂P�񂫂�Ȃ̂ŁC�t�B�[���h�ϐ���p�ӂ��Ȃ��Ă�����
        Text myText = GetComponent<Text>();
        //text�ɋ�̕������ݒ肷��
        myText.text = "";
    }

   
}
