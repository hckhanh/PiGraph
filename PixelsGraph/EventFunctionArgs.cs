using System;

namespace PixelsGraph
{
    public class EventFunctionArgs : EventArgs
    {
        public EventFunctionArgs(Function funct, bool isEditFunction = false)
        {
            Function = funct;
            this.isEditFunction = isEditFunction;
        }

        public bool isEditFunction = false;

        public bool IsEditFunction
        {
            get
            {
                return isEditFunction;
            }
        }

        public Function Function
        {
            get;
            set;
        }
    }
}
