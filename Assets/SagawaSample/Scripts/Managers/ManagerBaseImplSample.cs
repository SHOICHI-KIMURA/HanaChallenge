using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ManagerBaseImplSample : ManagerBase<ManagerBaseImplSample>
{
    /// <summary>
    /// ベースクラス実装側の初期化処理
    /// </summary>
    private void Init()
    {
        Debug.Log($"[Method Call] {GetType()} Init");

    }

    /// <summary>
    /// 親の初期化処理の後
    /// </summary>
    protected override void OnInitialized()
    {
        Debug.Log($"[Method Call] {GetType()} OnInitialized");

        Init();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void OnRelease()
    {
        Debug.Log($"[Method Call] {GetType()} OnRelease");
    }
}
