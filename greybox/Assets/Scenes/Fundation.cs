using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fundation : MonoBehaviour
{
    public Transform pigTransform; // 变量名改为pigTransform
    public float moveStep = 2.0f;
    public float scaleFactor = 0.2f;
    public float rotateSpeed = 30f;

    private Vector3 initialPosition;
    private Vector3 initialScale;
    private Quaternion initialRotate;

    void Start()
    {
        // 查找对象名改为"Pig"
        GameObject pigObject = GameObject.Find("pig"); 

        if (pigObject != null)
        {
            pigTransform = pigObject.transform; // 变量同步修改
            initialPosition = pigTransform.position;
            initialScale = pigTransform.localScale;
            initialRotate = pigTransform.rotation;
            Debug.Log("pig Find! "); // 日志信息更新
        }
        else
        {
            Debug.LogError("pig Not Found！"); // 错误信息更新
        }
    }

    // 以下方法中的操作对象全部改为pigTransform
    public void MoveLeft()
    {
        pigTransform.Translate(-moveStep, 0, 0);
    }

    public void MoveRight()
    {
        pigTransform.Translate(moveStep, 0, 0);
    }

    public void ScaleUp()
    {
        pigTransform.localScale *= (1 + scaleFactor);
    }

    public void ScaleDown()
    {
        pigTransform.localScale *= (1 - scaleFactor);
    }

    public void ResetAll()
    {
        pigTransform.position = initialPosition;
        pigTransform.localScale = initialScale;
        pigTransform.rotation = initialRotate;
    }

    public void Rotate() 
    {
        pigTransform.Rotate(0, rotateSpeed, 0); 
    }
}
