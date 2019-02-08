using System.Runtime.Serialization;

namespace Csharp.Day4.Example5
{
    public class Owner: ISerializable
    {
        public string Name { get; set; }
        public int ID { get; set; }


        public Owner(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public override string ToString()
        {
            return string.Format("{0} is owner with ID {1}",
                Name, ID);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("ID", ID);
        }

        public Owner(SerializationInfo info, StreamingContext ctext)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            ID = (int)info.GetValue("ID", typeof(int));
        }
    }
}