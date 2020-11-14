using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Files_Serialize_Deck
{
    class Program
    {
        

        static void Main(string[] args)
        {
            CardComparerBySuit comparerBySuit = new CardComparerBySuit();
            Deck deck = new Deck();

            List<Card> cards = new List<Card>();
            cards = deck.GetCardsFull();
            cards.Sort(comparerBySuit);  

            string path = @"C:\Projetos\Projetos\Cursos\Curso-de-CSharp-Avancado-Arquivos\cards.txt";

            SerializarObjeto(path, cards);

            DeserializarObjeto(path);


            Console.ReadKey();          

        }

        private static void SerializarObjeto(string path, List<Card> cards)
        {
            using (Stream output = File.Create(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, cards);
            }
        }

        private static void DeserializarObjeto(string path)
        {
            using (Stream input = File.OpenRead(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                List<Card> cardss = (List<Card>)formatter.Deserialize(input);

                foreach (var item in cardss)
                {
                    Console.WriteLine("-> " + item.Name);
                }
            }
        }
    }
}
