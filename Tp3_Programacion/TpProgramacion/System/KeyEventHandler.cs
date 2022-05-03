namespace System
{
    internal class KeyEventHandler
    {
        private Action<object, EventArgs> txtPrecio_Nuevo_TextChanged;

        public KeyEventHandler(Action<object, EventArgs> txtPrecio_Nuevo_TextChanged)
        {
            this.txtPrecio_Nuevo_TextChanged = txtPrecio_Nuevo_TextChanged;
        }
    }
}