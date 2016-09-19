using Teigha.Runtime;

namespace ReactorDocumentManager
{
    class Initialization : IExtensionApplication
    {
        /// <summary>
        /// dll がロードされたときに実行する
        /// </summary>
        public void Initialize()
        {
            // ドキュメント マネージャーにリアクターを追加
            DocumentManager.AddReactor();
        }

        /// <summary>
        /// dll がアンロードされるときに実行される
        /// </summary>
        public void Terminate()
        {
            // ドキュメント マネージャからリアクターを削除
            DocumentManager.RemoveReactor();
        }
    }
}
