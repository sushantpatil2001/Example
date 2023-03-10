// See https://aka.ms/new-console-template for more information
//Question 1
using System;
namespace KhataBook
{
    class Khata
    {
        Dictionary<string, int> record = new Dictionary<string, int>();
        public Khata(Dictionary<string, int> Record){
            record=Record;
        }
        public int getTotal()
        {
            int total=0;
            foreach(KeyValuePair<string,int> a in record)
            {
                total+=a.Value;
            }
            return total;
        }
        public int getRepeatAmount(){
                return record.Count;
        }
    } 
    class driver
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> record = new Dictionary<string, int>();
            record.Add("milk",100);
            record.Add("tea",10);
            Khata khata = new Khata(record);
            Console.WriteLine(khata.getRepeatAmount());
            Console.WriteLine(khata.getTotal());
        }
        

    }   
}
