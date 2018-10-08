using System;

namespace NickNameGen
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Recipe
			// Determine variables
			// Ask user for first name
			// Ask user for last name
			// Display list of discriptives to user
			// Ask user to choose 1 descriptive
			// Make selection ToUpper
			// Case with Adjectives that contain Arrays for each selection
			// Try catch makes sure the user inputs a valid choice
			// Random chooses a synonym 
			// While makes sure the user does not get the same synonym
			// Displays to the user a nickname for both first and last name
			// Nickname structure:
			// synonym first name
			// synonym last name

			String fName;
			String lName;

			Console.WriteLine("Use this handy nickname generator to choose a simple, yet fun nickname!");

            
			    Console.WriteLine("What is your first name?");
		        fName = Console.ReadLine();
             
			
                Console.WriteLine("What is your last name?");
			    lName = Console.ReadLine();
			
			Descriptives(fName, lName);
		}

		//method contains arrays for descriptives
		static void Descriptives(string fName, string lName)
		{
			bool invalidDes;
			invalidDes = false;
			Random randomDes = new Random();
            String finalDes;
            String finalDes2;

			do
			{
				invalidDes = true;
				Console.WriteLine("Choose one trait or descriptive that best fits: " + "Nice, Talented, Funny, Quiet, Cool, or Tired.");
				String Des = Console.ReadLine().ToUpper();

				try
				{
					switch (Des)
					{
						case "NICE":
							string[] Nice = { "Kind", "Generous", "Pleasant", "Agreeable", "Delightful", "Lovely" };

							finalDes = Nice[randomDes.Next(6)];
							finalDes2 = Nice[randomDes.Next(6)];

							while(finalDes == finalDes2)

							{
								finalDes2 = Nice[randomDes.Next(6)];
							}

							Console.WriteLine("NickNames: " + "{0} {1}, " + "{2} {3}", finalDes, fName, finalDes2, lName);

							invalidDes = true;
							break;


						case "TALENTED":
							string[] Talented = { "Gifted", "Creative", "Skilled", "Expert", "Accomplished", "Apt" };

							finalDes = Talented[randomDes.Next(6)];
							finalDes2 = Talented[randomDes.Next(6)];

							while(finalDes == finalDes2)

							{
								finalDes2 = Talented[randomDes.Next(6)];
							}

							Console.WriteLine("NickNames: " + "{0} {1}, " + "{2} {3}", finalDes, fName, finalDes2, lName);

							invalidDes = true;
							break;

						case "FUNNY":
							string[] Funny = { "Hilarious", "Humorous", "Comical", "Witty", "Amusing", "Jokester" };

							finalDes = Funny[randomDes.Next(6)];
							finalDes2 = Funny[randomDes.Next(6)];

							while(finalDes == finalDes2)

							{
								finalDes2 = Funny[randomDes.Next(6)];
							}

							Console.WriteLine("NickNames: " + "{0} {1}, " + "{2} {3}", finalDes, fName, finalDes2, lName);

							invalidDes = true;
							break;

						case "QUIET":
							string[] Quiet = { "Shy", "Hushed", "Secretive", "Private", "Still", "Thoughtful" };
                            
							finalDes = Quiet[randomDes.Next(6)];
							finalDes2 = Quiet[randomDes.Next(6)];

							while(finalDes == finalDes2)

							{
								finalDes2 = Quiet[randomDes.Next(6)];
							}

							Console.WriteLine("NickNames: " + "{0} {1}, " + "{2} {3}", finalDes, fName, finalDes2, lName);

							invalidDes = true;
							break;

						case "COOL":
							string[] Cool = { "Edgy", "Original", "Slick", "Chic", "Fly", "Controlled" };
                            
							finalDes = Cool[randomDes.Next(6)];
							finalDes2 = Cool[randomDes.Next(6)];

							while(finalDes == finalDes2)

							{
								finalDes2 = Cool[randomDes.Next(6)];
							}

							Console.WriteLine("NickNames: " + "{0} {1}, " + "{2} {3}", finalDes, fName, finalDes2, lName);

							invalidDes = true;
							break;

						case "TIRED":
							string[] Tired = { "Zonked", "Weary", "Jaded", "Drained", "Wasted", "Spent" };

							finalDes = Tired[randomDes.Next(6)];
							finalDes2 = Tired[randomDes.Next(6)];

							while(finalDes == finalDes2)

							{
								finalDes2 = Tired[randomDes.Next(6)];
							}

							Console.WriteLine("NickNames: " + "{0} {1}, " + "{2} {3}", finalDes, fName, finalDes2, lName);

							invalidDes = true;
							break;

						default:
							Console.WriteLine("Please choose a descriptive...");
							invalidDes = false;
							break;

					}
				}

				catch (FormatException)
				{
					Console.WriteLine("Please type out descriptive...");
					invalidDes = false;
				}
			} while (invalidDes == false); //Continue to ask user for valid description

		}
	}
}
