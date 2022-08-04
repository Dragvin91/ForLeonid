using ForLeonid.MainWindow;

namespace ForLeonid
{
    internal class GlobalVariable
    {
        private static GlobalVariable globalVariable;
        private GlobalVariable()
        {
                
        }

       static public GlobalVariable GetGlobalVariable()
        {
            return globalVariable ??= new GlobalVariable();
        }

        public iMainWindow MainWindow { get; set; }
    }
}
