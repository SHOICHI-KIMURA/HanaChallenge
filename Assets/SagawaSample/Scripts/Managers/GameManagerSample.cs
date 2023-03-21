using UnityEngine;


/// <summary>
/// ゲームマネージャ用シングルトンクラスサンプル
/// </summary>
[DisallowMultipleComponent]
public class GameManagerSample : MonoBehaviour
{
    public static GameManagerSample Instance
    {
        get;
        private set;
    } = null;

    [SerializeField]
    private string _userName;

    void Awake()
    {
        Debug.Log($"[Method Call] {GetType()} Awake");

        if (Instance == null)
        {
            // Instanceに値セット
            Instance = this;
            // 破棄しないように
            DontDestroyOnLoad(gameObject);

            // メソッド抜ける
            return;
        }

        // 複数のインスタンスを作らないように、Instanceに値セットした後はインスタンス破棄する
        Destroy(this);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnDestroy()
    {
        Debug.Log($"[Method Call] {GetType()} OnDestroy");

        // Instanceが自分自身と同じなら破棄する
        if (Instance == this)
        {
            Instance = null;
        }

        Reset();
    }

    public void SetName(string userName)
    {
        _userName = userName;
    }

    private void Reset()
    {
        _userName = "";
    }
}
