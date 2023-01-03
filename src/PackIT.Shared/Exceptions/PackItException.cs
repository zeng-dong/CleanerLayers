using System.Runtime.Serialization;

namespace PackIT.Shared.Exceptions
{
    [Serializable]
    public abstract class PackItException : Exception
    {
        protected PackItException(string message) : base(message)
        {
        }

        protected PackItException(SerializationInfo info, StreamingContext context)
        : base(info, context)
        {
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}