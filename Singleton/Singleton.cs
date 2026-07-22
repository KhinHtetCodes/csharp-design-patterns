public sealed class Singleton
{
    // インスタンス化を防ぐため、コンストラクタをprivateにする
    private Singleton() {}
   // 唯一のインスタンスを保持するstatic変数
    private static Singleton _instance;
    // スレッド同期のためのロックオブジェクト (Lock object for thread synchronization).
     private static readonly object _lock = new object();

    // 唯一のインスタンスを取得するグローバルアクセスポイント
    public static Singleton GetInstance()
    {
        // スレッドセーフ（安全）にインスタンスを生成・取得するためのロック
        lock(_lock)
        {
            if( _instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}