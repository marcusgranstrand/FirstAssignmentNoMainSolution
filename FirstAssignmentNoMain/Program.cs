using FirstAssignmentNoMain.Classes;

int choice;
do
{
	Console.WriteLine("\t 1.)First Method\n" + "\t 2.)Second Method\n" +
					  "\t 3.)Third Method\n" + "\t 4.)Fourth Method\n" +
					  "\t 5.)Fifth Method\n" + "\t 0.)Exit Program\n");

	Console.WriteLine("Please make your choice: ");
	choice = int.Parse(Console.ReadLine());
	switch (choice)
	{
		case 1: Console.WriteLine(Methods.WhatIsYourName()); break;
		case 2: Console.WriteLine(Methods.PrefixText()); break;
		case 3: Console.WriteLine(Methods.EnteredText("Please enter a number: ")); break;
		case 4: Console.WriteLine(Methods.EnteredText2("number")); break;
		case 5: Console.WriteLine(Methods.FullName("Thomas", "Payne")); break;
		case 0: Console.WriteLine("Thanks for using the program!"); break;
		default: Console.WriteLine("Not a valid choice"); break;
	}

	Thread.Sleep(2000);         // Tried to use only clearing but I failed finding where to
	Console.Clear();            // put it so I still could see what was returned

} while (choice != 0);

Console.ReadKey();
