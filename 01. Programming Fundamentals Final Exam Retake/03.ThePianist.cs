using System.Net.NetworkInformation;

namespace _03.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Pianist> musiciansMap = new Dictionary<string, Pianist>();

            int numberOfPieces = int.Parse(Console.ReadLine());
            string piece = null;
            string composer = null;
            string newKey = null;
            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                piece = tokens[0];
                composer = tokens[1];
                newKey = tokens[2];
                Pianist musicians = new Pianist(composer, newKey);
                if (!musiciansMap.ContainsKey(piece))
                {
                    musiciansMap[piece] = musicians;
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] tokens = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "Add":
                        piece = tokens[1];
                        composer = tokens[2];
                        newKey = tokens[3];
                        Pianist musicianAdd = new Pianist(composer, newKey);
                        musicianAdd.Add(piece, composer, newKey, musiciansMap);
                        break;
                    case "Remove":
                        piece = tokens[1];
                        Pianist musicianRemove = new Pianist(composer, newKey);
                        musicianRemove.Remove(piece, musiciansMap);
                        break;
                    case "ChangeKey":
                        piece = tokens[1];
                        newKey = tokens[2];
                        Pianist changePiece = new Pianist(composer, newKey);
                        changePiece.ChangeKey(piece, newKey, musiciansMap);
                        break;
                }
            }
            
            foreach (var pieces in musiciansMap)
            {
                Console.WriteLine($"{pieces.Key} -> Composer: {pieces.Value.Composer}, Key: {pieces.Value.Key}");
            }
        }

    }
    class Pianist
    {
        public string Composer { get; set; }
        public string Key { get; set; }
        public Pianist(string composer, string key)
        {
            Composer = composer;
            Key = key;
        }
        public void Add(string piece, string composer, string key, Dictionary<string, Pianist> map)
        {
            if (map.ContainsKey(piece))
            {
                Console.WriteLine($"{piece} is already in the collection!");
                return;
            }
            Pianist pianist = new Pianist(composer, key);
            map.Add(piece, pianist);
            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
        }
        public void Remove(string piece, Dictionary<string, Pianist> map)
        {
            if (map.ContainsKey(piece))
            {
                map.Remove(piece);
                Console.WriteLine($"Successfully removed {piece}!");
                return;
            }
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");

        }
        public void ChangeKey(string piece, string newKey, Dictionary<string, Pianist> map)
        {
            if (map.ContainsKey(piece))
            {
                map[piece].Key = newKey;
                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                return;
            }
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
    }
}
