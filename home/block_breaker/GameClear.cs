using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameClear : MonoBehaviour
{
    public Text gameClearMessage;
    Transform myTransform;
    //�Q�[���N���A���ǂ������Ǘ�����t���O��p��
    bool isGameClear = false;

    // Start is called before the first frame update
    void Start()
    {
        //Transform�R���|�[�l���g��ێ����Ă���
        myTransform = transform;    
    }

    // Update is called once per frame
    void Update()
    {
        //�q�������Ȃ��Ȃ����Q�[�����~����
        if(myTransform.childCount == 0){
            gameClearMessage.text = "Game Clear";
            Time.timeScale = 0f;
            //�Q�[���N���A�̃t���O�𗧂Ă�
            isGameClear = true;
        }

        //�Q�[���N���A���Ă���C���{�^�����͂ŃV�[�����ă��[�h
        if(isGameClear && Input.GetButtonDown("Submit")){
            //timeScale���P�ɖ߂��Ă���
            Time.timeScale = 1f;
            //�V�[���̃��[�h
            SceneManager.LoadScene("Play");
        }
    }
}
