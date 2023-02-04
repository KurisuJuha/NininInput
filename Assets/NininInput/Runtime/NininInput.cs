using System;

namespace JuhaKurisu.PopoTools.Ninin
{
    public abstract class NininInput
    {
        public readonly Guid id;
        private readonly Guid key;

        public NininInput(Guid id, Guid key)
        {
            this.id = id;
            this.key = key;
        }

        public abstract byte[] Serialize();
        public abstract bool Deserialize(byte[] bytes);
    }
}