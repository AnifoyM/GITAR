using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*******************此类可以用来查找物体**************
 * 
 * 使用方法: transform.FindChildByName("name"); //transform用哪个节点就从哪个节点下m面查找,热更工程中有之前项目的案例
 * 
 * 
 * 
 ********************/
public static class TransformHelper
{
    //打印日志用
    public static Transform FindChildByName(this Transform childTF, string childName)
    {
        Transform trans = childTF.FindChildByName_Base(childName);
        if (trans == null)
            Debug.Log("未找到名为" + childName + "的物体");
        return trans;
    }
    //递归查找子物体下目标名字的物体名字
    private static Transform FindChildByName_Base(this Transform childTF, string childName)
    {
        //Debug.Log("查找");
        Transform temp = childTF.Find(childName);
        if (temp != null) return temp;

        for (int i = 0; i < childTF.childCount; i++)
        {
            temp = FindChildByName_Base(childTF.GetChild(i), childName);
            if (temp != null) return temp;
        }
        return null;
    }


    /// <summary>
    /// 查找是否有目标组件,没有的话动态添加
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="childTF"></param>
    /// <returns></returns>
    public static T GetOrAddComponent<T>(this Transform childTF) where T : Component
    {
        if (childTF.GetComponent<T>() == null)
            childTF.gameObject.AddComponent<T>();
        return childTF.GetComponent<T>();

    }
    public static T GetOrAddComponentInchild<T>(this Transform childTF, string childName) where T : Component
    {
        Transform child = FindChildByName(childTF, childName);
        if (!child) return null;
        child.GetOrAddComponent<T>();
        return child.GetComponent<T>();
    }

    //对子物体查找某个组件
    public static T GetComponentByChildName<T>(this Transform childTF, string childName) where T : Component
    {
        T t;
        Transform child = FindChildByName(childTF, childName);
        if (!child) return null;
        if (child.TryGetComponent(out t))
        {
            return t;
        }
        else
        {
            Debug.LogError("未找到目标组件");
            return null;
        }
    }

    //删除目标下面所有物体
    public static void DestroyAllChild(this Transform trans)
    {
        for (int i = trans.childCount - 1; i >= 0; i--)
        {
            GameObject.Destroy(trans.GetChild(i));
            Debug.LogError("已删除");
        }
    }

    //遍历目标节点下所有子物体(仅子物体,不包含孙物体)
    public static GameObject[] FindChilds(this Transform trans)
    {
        List<GameObject> childs = new List<GameObject>();
        for (int i = 0; i < trans.childCount; i++)
        {
            childs.Add(trans.GetChild(i).gameObject);
        }
        //Debug.Log("子物体个数(不包含孙物体):" + childs.Count);
        return childs.ToArray();
    }
    //遍历目标节点下所有子物体(仅子物体,不包含孙物体) 
    public static T[] FindChildsByComponent<T>(this Transform trans) where T : Component
    {
        GameObject[] gos = trans.FindChilds();
        //return gos.FindAll((a)=> { a.GetComponent<T>(); });
        List<T> tList = new List<T>();
        foreach (var go in gos)
        {
            T t;
            if (go.TryGetComponent(out t))
            {
                tList.Add(t);
            }
        }
        return tList.ToArray();

    }



}

