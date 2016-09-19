using PCAD_DOT_NET;
using Teigha.Core;
using Teigha.Runtime;
using Teigha.TD;

namespace SelectEntity
{
    public class SelectEntity
    {
        [CommandMethod("SelecEntity", "SelectEntity", CommandFlags.Modal)]
        public void SelectEntityCommand()
        {
            var document = PCADGlobals.ACTIVE_DOCUMENT();
            var database = document.GetFxDatabase();
            var userIo = document.GetFxUserIO();

            var commandContext = document.GetFxCommandContext();
            var prompt = userIo.GetPrompt(new CFxString("エンティティを選択"));
            var selectionSet = PCADGlobals.CreateSelectionSet(commandContext);
            var point = new OdGePoint3d();
            bool pointInput;
            var promptStatus = userIo.DoEntsel(prompt, selectionSet, null, point, out pointInput);

            if (promptStatus == (int)PromptStatus.Normal)
            {
                var objectId = selectionSet.GetId(0);
                var entity = OdDbEntity.cast(objectId.safeOpenObject(OpenMode.kForWrite));
                entity.setColorIndex(2);
            }
        }
    }
}
