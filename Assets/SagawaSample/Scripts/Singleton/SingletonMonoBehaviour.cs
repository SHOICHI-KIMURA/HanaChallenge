using UnityEngine;


/// <summary>
/// MonoBehaviour用のシングルトン抽象クラス
/// </summary>
/// <typeparam name="T">SingletonMonoBehaviour<T>を継承したクラスを指定する</typeparam>
/// <remarks></remarks>
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
    // 参考リンク

    public static T Instance
    {
        get;
        private set;
    } = null;

    /// <summary>
    /// Singletonが有効かどうか
    /// Instanceがnullじゃなければ値がセットされているので有効
    /// </summary>
    /// <returns></returns>
    public static bool IsValid() => Instance != null;

    void Awake()
    {
        Debug.Log($"[Method Call] SingletonMonoBehaviour Awake");

        if (Instance == null)
        {
            // ジェネリックで受けとったT型でキャスト
            // Instanceに値セット
            //Instance = FindObjectOfType<T>();
            Instance = this as T;

            OnAwake();

            // メソッド抜ける
            return;
        }

        // 複数のインスタンスを作らないように、Instanceに値セットした後はインスタンス破棄する
        Destroy(this);
    }

    /// <summary>
    /// 継承先でAwake使えないので、代わりの初期化メソッド
    /// </summary>
    protected abstract void OnAwake();

    void OnDestroy()
    {
        Debug.Log($"[Method Call] SingletonMonoBehaviour OnDestroy");

        // Instanceが自分自身と同じなら破棄する
        if (Instance == this)
        {
            Instance = null;
        }
        OnRelease();
    }

    /// <summary>
    /// 継承先でOnDestroy使えないので、代わりの削除用メソッド
    /// </summary>
    protected abstract void OnRelease();
}
