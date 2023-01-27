class SecondTry
{

    public static void Main(string[] args)
    {

        string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\splen\Documents\Final_Project_Hangman\data_base_second_try.csv");

        var animalNames = new List<string>();

        int rnd = new Random().Next(0, 11);

        //Console.WriteLine(rnd);

        for (int i = 0; i < csvLines.Length; i++)
        {

            string[] rawData = csvLines[i].Split(';');// spotting in rows
            animalNames.Add(rawData[0]);

            for (int j = 0; j < rawData.Length; j++)

            {
                /* Console.WriteLine(rawData[j]);*///writes all csv file in line

            }

        }

        for (int i = 0; i < 1; i++)
        {

            //Console.WriteLine(animalNames[i]);
            Random randi = new Random(); //doesnt do anything
            int one = randi.Next(0, 11);
            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine(animalNames[rnd]);

            }



        }


        Console.WriteLine(animalNames[rnd]);




    }





}