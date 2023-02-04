namespace JuhaKurisu.PopoTools.Ninin
{
    public interface INininInput
    {
        public byte[] Serialize();
        public bool Deserialize(byte[] bytes);
    }
}