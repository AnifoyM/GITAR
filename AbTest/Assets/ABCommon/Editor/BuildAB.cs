using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class BuildAB : MonoBehaviour
{
    //ѹ�����������:https://blog.csdn.net/ultramansail/article/details/89053790
    #region BuildAssetBundleOptions.None
    [MenuItem("Tools/Build AssetBundles/None(LZMAѹ��_��С)/IOS")]
    static void BuildAllAssetBundlesForIOS_none()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.None);
    }
    [MenuItem("Tools/Build AssetBundles/None(LZMAѹ��_��С)/Android")]
    static void BuildAllAssetBundlesForAndroid_none()
    {
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.None);
    }
    [MenuItem("Tools/Build AssetBundles/None(LZMAѹ��_��С)/PC")]
    static void BuildAllAssetBundlesForPC_none()
    {
        BuildAllAssetBundlesForPC(BuildAssetBundleOptions.None);
    }
    [MenuItem("Tools/Build AssetBundles/None(LZMAѹ��_��С)/Android && IOS   %#&n")]
    static void BuildAllAssetBundlesForAndroidAndIOS_none()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.None);
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.None);
    }
    [MenuItem("Tools/Build AssetBundles/None(LZMAѹ��_��С)/ALLPlatform")]
    static void BuildAllAssetBundlesForALLPlatform_none()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.None);
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.None);
        BuildAllAssetBundlesForPC(BuildAssetBundleOptions.None);
    }
    #endregion
    #region BuildAssetBundleOptions.UncompressedAssetBundle
    [MenuItem("Tools/Build AssetBundles/UncompressedAssetBundle(��ѹ��_����Ƶ)/IOS")]
    static void BuildAllAssetBundlesForIOS_UncompressedAssetBundle()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.UncompressedAssetBundle);
    }
    [MenuItem("Tools/Build AssetBundles/UncompressedAssetBundle(��ѹ��_����Ƶ)/Android")]
    static void BuildAllAssetBundlesForAndroid_UncompressedAssetBundle()
    {
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.UncompressedAssetBundle);
    }
    [MenuItem("Tools/Build AssetBundles/UncompressedAssetBundle(��ѹ��_����Ƶ)/PC")]
    static void BuildAllAssetBundlesForPC_UncompressedAssetBundle()
    {
        BuildAllAssetBundlesForPC(BuildAssetBundleOptions.UncompressedAssetBundle);
    }
    [MenuItem("Tools/Build AssetBundles/UncompressedAssetBundle(��ѹ��_����Ƶ)/Android && IOS  %#&u")]
    static void BuildAllAssetBundlesForAndroidAndIOS_UncompressedAssetBundle()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.UncompressedAssetBundle);
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.UncompressedAssetBundle);
    }

    [MenuItem("Tools/Build AssetBundles/UncompressedAssetBundle(��ѹ��_����Ƶ)/ALLPlatform")]
    static void BuildAllAssetBundlesForALLPlatform_UncompressedAssetBundle()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.UncompressedAssetBundle);
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.UncompressedAssetBundle);
        BuildAllAssetBundlesForPC(BuildAssetBundleOptions.UncompressedAssetBundle);
    }

    #endregion
    #region BuildAssetBundleOptions.ChunkBaseCompression
    [MenuItem("Tools/Build AssetBundles/ChunkBasedCompression(LZ4�㷨ѹ��)/IOS")]
    static void BuildAllAssetBundlesForIOS_ChunkBaseCompression()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.ChunkBasedCompression);
    }
    [MenuItem("Tools/Build AssetBundles/ChunkBasedCompression(LZ4�㷨ѹ��)/Android")]
    static void BuildAllAssetBundlesForAndroid_ChunkBaseCompression()
    {
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.ChunkBasedCompression);
    }
    [MenuItem("Tools/Build AssetBundles/ChunkBasedCompression(LZ4�㷨ѹ��)/PC")]
    static void BuildAllAssetBundlesForPC_ChunkBaseCompression()
    {
        BuildAllAssetBundlesForPC(BuildAssetBundleOptions.ChunkBasedCompression);
    }
    [MenuItem("Tools/Build AssetBundles/ChunkBasedCompression(LZ4�㷨ѹ��)/Android && IOS  %#&C")]
    static void BuildAllAssetBundlesForAndroidAndIOS_ChunkBaseCompression()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.ChunkBasedCompression);
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.ChunkBasedCompression);
    }

    [MenuItem("Tools/Build AssetBundles/ChunkBasedCompression(LZ4�㷨ѹ��)/ALLPlatform")]
    static void BuildAllAssetBundlesForALLPlatform_ChunkBaseCompression()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.ChunkBasedCompression);
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.ChunkBasedCompression);
        BuildAllAssetBundlesForPC(BuildAssetBundleOptions.ChunkBasedCompression);
    }

    #endregion

    static void BuildAllAssetBundlesForIOS( BuildAssetBundleOptions BuildAssetBundleOptions)
    {
        string assetBundleDirectory = "Assets/../AssetBundles/IOS";
        if (!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
        }
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions, BuildTarget.iOS);
    }
    static void BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions BuildAssetBundleOptions)
    {
        string assetBundleDirectory = "Assets/../AssetBundles/Android";
        if (!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
        }
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions, BuildTarget.Android);
    }

    static void BuildAllAssetBundlesForPC(BuildAssetBundleOptions BuildAssetBundleOptions)
    {
        string assetBundleDirectory = "Assets/../AssetBundles/PC";
        if (!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
        }
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions, BuildTarget.StandaloneWindows);
    }
    

}
