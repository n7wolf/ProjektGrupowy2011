
namespace StudentsDatabase.Core
{
    public class Przedmiot
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public string Prowadzacy { get; set; }

        public override string ToString()
        {
            return string.Format("ID: {0}, \"{1}\", Prowadzacy: {2}", ID, Nazwa, Prowadzacy);
        }
    }
}
