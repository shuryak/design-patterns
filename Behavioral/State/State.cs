using System;

namespace DesignPatterns.Behavioral.State
{
    public abstract class State
    {
        protected Context Context;

        public void SetContext(Context context)
        {
            Context = context;
        }

        public abstract void Handle1();

        public abstract void Handle2();
    }
}
