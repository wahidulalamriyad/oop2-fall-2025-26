namespace NameSpaces
{
    public class House
    {
        public string Address { get; set; }
        public int NumberOfRooms { get; set; }

        public House(string address, int numberOfRooms)
        {
            Address = address;
            NumberOfRooms = numberOfRooms;
        }

        public override string ToString()
        {
            return $"{Address}, Rooms: {NumberOfRooms}";
        }
    }
}