namespace MiniFileBase
{
    public static class PersonSerializer
    {
        public static string SerializeToFile(Person person) => person.Id.ToString() + "|" + person.Name;

        public static Person DeserializePerson(string line)
        {
            Person person = new Person();
            var lines = line.Split('|');
            person.Id = int.Parse(lines[0]);
            person.Name = lines[1];

            return person;
        } 
    }
}
