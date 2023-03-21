using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// マネージャーベースクラス
/// マネージャークラスを作る場合は、必ず継承する
/// </summary>
/// <typeparam name="T"></typeparam>
[DisallowMultipleComponent]
public abstract class ManagerBase<T> : SingletonMonoBehaviour<T> where T : ManagerBase<T>
{
    /// <summary>
    /// 初期化処理
    /// </summary>
    public virtual void Initialize()
    {
        Debug.Log($"[Method Call] ManagerBase Initialize");

        OnInitialized();
    }

    protected override void OnAwake()
    {
        Debug.Log($"[Method Call] ManagerBase OnAwake");

        Initialize();
    }

    /// <summary>
    /// 継承先の初期化処理
    /// </summary>
    protected abstract void OnInitialized();
}
