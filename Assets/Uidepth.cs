using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// UI的特效叠层控制
/// </summary>
public class Uidepth : MonoBehaviour {

    public int depthorder;//设置绘制深度
    public bool isUI=true;//判断是否为ui组件或者是粒子特效
                         
    void Start () {

        if (isUI)
        {//是ui
            Canvas canvas=GetComponent<Canvas>();
            if (canvas==null)
            {//Canvas不存在时
                canvas= this.gameObject.AddComponent<Canvas>();//绑定canvas
            }
            canvas.overrideSorting = true;//允许绘制排序  忽略ugui的默认父子级渲染次序
            canvas.sortingOrder = depthorder;//设置绘制深度


        }
        else
        {//是粒子特效
            Renderer[] render = this.GetComponentsInChildren<Renderer>();//获取所有的Renderer组件
            foreach (Renderer item in render)
            {
                item.sortingOrder = depthorder;//设置绘制深度
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
