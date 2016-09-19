using PCAD_DOT_NET;
using Teigha.Runtime;

namespace ReactorDocumentManager
{
    public class DocumentManager
    {
        private static RunReactor _reactor;

        /// <summary>
        /// ドキュメント マネージャーにリアクターを追加
        /// </summary>
        public static void AddReactor()
        {
            _reactor = new RunReactor();
            var documentManager = PCADGlobals.GetFxSystemServices().GetFxDocumentManager();
            documentManager.AddReactor(_reactor);
        }

        /// <summary>
        /// ドキュメント マネージャーからリアクターを削除
        /// </summary>
        public static void RemoveReactor()
        {
            var documentManager = PCADGlobals.GetFxSystemServices().GetFxDocumentManager();
            documentManager.RemoveReactor(_reactor);
        }

        /// <summary>
        /// ドキュメント マネージャーにリアクターを追加するコマンド
        /// </summary>
        [CommandMethod("MyGroup", "Add", CommandFlags.Modal)]
        public void AddCommand()
        {
            AddReactor();
        }

        /// <summary>
        /// ドキュメント マネージャーからリアクターを削除するコマンド
        /// </summary>
        [CommandMethod("MyGroup", "Remove", CommandFlags.Modal)]
        public void RemoveCommand()
        {
            RemoveReactor();
        }
    }
}
