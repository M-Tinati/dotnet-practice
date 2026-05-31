Console.WriteLine("Select Your Number:");
try
{
    Console.WriteLine(" 1 : Editor Code");
    Console.WriteLine(" 2 : Create Object");
    Console.WriteLine(" 3 : Exit");

    int NumSelectUser = Convert.ToInt32(Console.ReadLine());
    switch (NumSelectUser)
    {
        case 1:
            {
                int Counter = 0;
                Console.WriteLine("Write code or text");
                do
                {
                    string UserWrite = Console.ReadLine();
                    Console.WriteLine(UserWrite);
                    Counter++;
                }
                while (Counter < 3);
                break;
            }
        case 2:
            {
                Console.WriteLine("How many parts does your name have?");
                string UserAnswer = Console.ReadLine();
                int ConvertAnswer = Convert.ToInt32(UserAnswer);
                string[] Name = new string[ConvertAnswer];
                for (int i = 0; i < ConvertAnswer; i++)
                {
                    Console.WriteLine($"Enter part {i + 1} of your name:");
                    Name[i] = Console.ReadLine();
                }

                Console.WriteLine("Your name is : ");
                foreach (string i in Name)
                {
                    Console.Write(i);
                }
                break;
            }
        case 3:
            {
                Console.ReadKey();
                break;
            }
    }

}
catch
{
    Console.WriteLine("Please Enter just Number");
}
