using System;
using System.Security.Cryptography;
using System.Text;

Console.WriteLine("Enter a hashing algorithm (MD5, SHA1, SHA256, SHA384, SHA512):");
string hashAlgorithm = Console.ReadLine();
HashAlgorithm hash = HashAlgorithm.Create(hashAlgorithm);

string username = null;
string hashedPass = null;
bool access = false;
string superSecureData = null;

while (true) {
    Console.WriteLine("1. Create/reset account");
    Console.WriteLine("2. Login to an account");
    Console.WriteLine("3. Print super secure data");
    Console.WriteLine("4. Exit");
    
    int menuOption = Convert.ToInt32((Console.ReadLine()));

    if (menuOption == 1)
    {
        Console.WriteLine("Enter a new username: ");
        username = Console.ReadLine();
        
        Console.WriteLine("Enter a new password: ");
        string unhashedPass = Console.ReadLine();
        string salt = "y&@7z)?ak%";
        string readyToBeHashed = unhashedPass + salt;
        byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(readyToBeHashed));
        var sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        hashedPass = sBuilder.ToString();
        
        Console.WriteLine("Repeat your password: ");
        string unhashedPass2 = Console.ReadLine();
        string readyToBeHashed2 = unhashedPass2 + salt;
        byte[] data2 = hash.ComputeHash(Encoding.UTF8.GetBytes(readyToBeHashed2));
        var sBuilder2 = new StringBuilder();
        for (int i = 0; i < data2.Length; i++)
        {
            sBuilder2.Append(data2[i].ToString("x2"));
        }
        string hashedPass2 = sBuilder2.ToString();

        if (hashedPass == hashedPass2)
        {
            Console.WriteLine("Thank you for creating an account. Your data has been hashed, salted and saved.");
            Console.WriteLine($"Your hashed password is {hashedPass}");
        }
        else
        {
            Console.WriteLine("Your passwords didn't match, please try again.");
        }
    }

    if (menuOption == 2)
    {
        Console.WriteLine("Hello there! Please enter your username.");
        string loginUsername = Console.ReadLine();

        if (loginUsername == username)
        {
            Console.WriteLine($"Welcome {username}, please enter your password.");
            string loginPassword = Console.ReadLine();
            string salt = "y&@7z)?ak%";
            string readyToBeHashed = loginPassword + salt;
            byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(readyToBeHashed));
            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            string hashedLoginPass = sBuilder.ToString();

            if (hashedLoginPass == hashedPass)
            {
                access = true;
                Console.WriteLine($"{username}, your password has been successfully hashed and verified!");
                Console.WriteLine("Please enter your super secure data!");
                superSecureData = Console.ReadLine();
                Console.WriteLine("Your super secure data has been saved! :)");
            }
            else
            {
                Console.WriteLine("Your password was incorrect. Please try again.");
            }
        }
        else
        {
            Console.WriteLine("That is not a valid username. Please try again.");
        }

    }

    if (menuOption == 3)
    {
        if (superSecureData != null && access == true)
        {
            Console.WriteLine($"Your super secret data is: {superSecureData}");
        }
        else
        {
            Console.WriteLine("You have not logged in yet!");
        }
    }

    if (menuOption == 4)
    {
        Environment.Exit(69);
    }
}