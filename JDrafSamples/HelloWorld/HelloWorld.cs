using PCAD_DOT_NET;
using Teigha.Runtime;

namespace HelloWorld
{
    public class HelloWorld
    {
        [CommandMethod("HelloWorld", "HelloWorld", CommandFlags.Modal)]
        public void HelloWorldCommand()
        {
            var document = PCADGlobals.ACTIVE_DOCUMENT();
            var userIo = document.GetFxUserIO();
            userIo.Write(new CFxString("Hello World"));
        }
    }
}
