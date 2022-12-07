using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class BuildAB : MonoBehaviour
{
    //压缩比率详情见:https://blog.csdn.net/ultramansail/article/details/89053790
    #region BuildAssetBundleOptions.None
    [MenuItem("Tools/Build AssetBundles/None(LZMA压缩_包小)/IOS")]
    static void BuildAllAssetBundlesForIOS_none()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.None);
    }
    [MenuItem("Tools/Build AssetBundles/None(LZMA压缩_包小)/Android")]
    static void BuildAllAssetBundlesForAndroid_none()
    {
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.None);
    }
    [MenuItem("Tools/Build AssetBundles/None(LZMA压缩_包小)/PC")]
    static void BuildAllAssetBundlesForPC_none()
    {
        BuildAllAssetBundlesForPC(BuildAssetBundleOptions.None);
    }
    [MenuItem("Tools/Build AssetBundles/None(LZMA压缩_包小)/Android && IOS   %#&n")]
    static void BuildAllAssetBundlesForAndroidAndIOS_none()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.None);
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.None);
    }
    [MenuItem("Tools/Build AssetBundles/None(LZMA压缩_包小)/ALLPlatform")]
    static void BuildAllAssetBundlesForALLPlatform_none()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.None);
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.None);
        BuildAllAssetBundlesForPC(BuildAssetBundleOptions.None);
    }
    #endregion
    #region BuildAssetBundleOptions.UncompressedAssetBundle
    [MenuItem("Tools/Build AssetBundles/UncompressedAssetBundle(不压缩_有视频)/IOS")]
    static void BuildAllAssetBundlesForIOS_UncompressedAssetBundle()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.UncompressedAssetBundle);
    }
    [MenuItem("Tools/Build AssetBundles/UncompressedAssetBundle(不压缩_有视频)/Android")]
    static void BuildAllAssetBundlesForAndroid_UncompressedAssetBundle()
    {
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.UncompressedAssetBundle);
    }
    [MenuItem("Tools/Build AssetBundles/UncompressedAssetBundle(不压缩_有视频)/PC")]
    static void BuildAllAssetBundlesForPC_UncompressedAssetBundle()
    {
        BuildAllAssetBundlesForPC(BuildAssetBundleOptions.UncompressedAssetBundle);
    }
    [MenuItem("Tools/Build AssetBundles/UncompressedAssetBundle(不压缩_有视频)/Android && IOS  %#&u")]
    static void BuildAllAssetBundlesForAndroidAndIOS_UncompressedAssetBundle()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.UncompressedAssetBundle);
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.UncompressedAssetBundle);
    }

    [MenuItem("Tools/Build AssetBundles/UncompressedAssetBundle(不压缩_有视频)/ALLPlatform")]
    static void BuildAllAssetBundlesForALLPlatform_UncompressedAssetBundle()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.UncompressedAssetBundle);
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.UncompressedAssetBundle);
        BuildAllAssetBundlesForPC(BuildAssetBundleOptions.UncompressedAssetBundle);
    }

    #endregion
    #region BuildAssetBundleOptions.ChunkBaseCompression
    [MenuItem("Tools/Build AssetBundles/ChunkBasedCompression(LZ4算法压缩)/IOS")]
    static void BuildAllAssetBundlesForIOS_ChunkBaseCompression()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.ChunkBasedCompression);
    }
    [MenuItem("Tools/Build AssetBundles/ChunkBasedCompression(LZ4算法压缩)/Android")]
    static void BuildAllAssetBundlesForAndroid_ChunkBaseCompression()
    {
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.ChunkBasedCompression);
    }
    [MenuItem("Tools/Build AssetBundles/ChunkBasedCompression(LZ4算法压缩)/PC")]
    static void BuildAllAssetBundlesForPC_ChunkBaseCompression()
    {
        BuildAllAssetBundlesForPC(BuildAssetBundleOptions.ChunkBasedCompression);
    }
    [MenuItem("Tools/Build AssetBundles/ChunkBasedCompression(LZ4算法压缩)/Android && IOS  %#&C")]
    static void BuildAllAssetBundlesForAndroidAndIOS_ChunkBaseCompression()
    {
        BuildAllAssetBundlesForIOS(BuildAssetBundleOptions.ChunkBasedCompression);
        BuildAllAssetBundlesForAndroid(BuildAssetBundleOptions.ChunkBasedCompression);
    }

    [MenuItem("Tools/Build AssetBundles/ChunkBasedCompression(LZ4算法压缩)/ALLPlatform")]
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
