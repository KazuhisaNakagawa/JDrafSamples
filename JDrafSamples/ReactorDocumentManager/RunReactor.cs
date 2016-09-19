using PCAD_DOT_NET;
using System.Windows.Forms;

namespace ReactorDocumentManager
{
    public class RunReactor : CFxDocumentManagerReactor
    {
        public override void DatabaseAttached(CFxDocument document)
        {
            base.DatabaseAttached(document);
            MessageBox.Show($"図面 {document.GetFxDatabase().getDWGNAME()} が開かれました。");
        }
        public override void DocumentActivated(CFxDocument document)
        {
            base.DocumentActivated(document);
            MessageBox.Show($"図面 {document.GetFxDatabase().getDWGNAME()} がアクティブになりました。");
        }
        public override void DatabaseDetached(CFxDocument document)
        {
            MessageBox.Show($"図面 {document.GetFxDatabase().getDWGNAME()} が閉じられます。");
            base.DatabaseDetached(document);
        }
    }
}