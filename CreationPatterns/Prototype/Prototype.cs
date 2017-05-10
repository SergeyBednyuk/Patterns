using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    [Serializable]
    public abstract class Prototype<T>
    {
        //поверхносное копирование
        public virtual T Clone()
        {
            return (T) MemberwiseClone();
        }
        //глубокое копирование
        public virtual T DeepClone()
        {
            using (var stream = new MemoryStream())
            {
                var context = new StreamingContext(StreamingContextStates.Clone);
                var formatter = new BinaryFormatter(){Context = context};
                formatter.Serialize(stream,this);
                stream.Position = 0;

                return (T) formatter.Deserialize(stream);
            }
        }
    }
}
