namespace ATM_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int accountNumber = 554433221;
            int pin = 1984;
            double balance = 50000.00;
            double transferAmount;
            double withdrawAmount;
            int option;
            try
            {

                Console.WriteLine("Hello, kindly enter your name to begin");
                string userName = Console.ReadLine();
                Console.WriteLine("Please enter a language of your choice\n 'E' for English,\n 'P' for Pidgin \n 'I' for igbo");
                string chosenLanguage = Console.ReadLine().ToUpper();

                if (chosenLanguage == "E")
                {
                    Console.Write("ENTER ACCOUNT NUMBER : ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    if (accountNumber != 554433221)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("INCORRECT ACCOUNT NUMBER ");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("ENTER ATM PIN # : ");
                        pin = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        if (pin != 1984)
                        {
                            Console.WriteLine("INCORRECT PIN NUMBER PLEASE TRY AGAIN");
                            Console.ReadLine();
                        }
                        else if (pin == 1984)
                        {
                            while (true)
                            {
                                Console.WriteLine("=================================");
                                Console.WriteLine("CHOOSE TRANSACTION: 1, 2, 3\n");
                                Console.WriteLine("1. INQUIRE\n");
                                Console.WriteLine("2. WITHDRAW\n");
                                Console.WriteLine("3. TRANSFER\n");
                                Console.WriteLine("4. EXIT PROGRAM \n");
                                Console.Write("CHOOSE TRANSACTION : ");
                                option = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                if (option == 1)
                                {
                                    Console.WriteLine("ACCOUNT NUMBER : " + accountNumber);
                                    Console.WriteLine("ACCOUNT NAME : " + userName);
                                    Console.WriteLine("BALANCE : N " + balance);
                                    Console.WriteLine("THANK YOU");
                                    Console.ReadLine();
                                }
                                else if (option == 2)
                                {
                                    Console.Write("ENTER AMOUNT TO WITHDRAW : ");
                                    withdrawAmount = Convert.ToDouble(Console.ReadLine());
                                    if (withdrawAmount > 10000.00)
                                    {

                                        Console.WriteLine("SORRY, WITHDRAWAL IS UP TO 10,000.00 MAXIMUM ONLY");
                                        Console.WriteLine("THIS IS YOUR REMAINING BALANCE: N " + balance);
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        balance = balance - withdrawAmount;
                                        Console.WriteLine("THIS IS YOUR REMAINING BALANCE: N " + balance);
                                        Console.WriteLine("THANK YOU");
                                        Console.ReadLine();
                                    }
                                }
                                else if (option == 3)
                                {
                                    Console.WriteLine("ENTER AMOUNT TO TRANSFER : ");
                                    transferAmount = Convert.ToDouble(Console.ReadLine());
                                    if (transferAmount > 10000.00)
                                    {

                                        Console.WriteLine("SORRY, TRANSFER AMOUNT IS 10,000.00 MAXIMUM ONLY");
                                        Console.WriteLine("THIS IS YOUR REMAINING BALANCE: N " + balance);
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        balance = balance - transferAmount;
                                        Console.WriteLine("THIS IS YOUR REMAINING BALANCE: N " + balance);
                                        Console.WriteLine("THANK YOU");
                                        Console.ReadLine();
                                    }
                                }
                                else if (option == 4)
                                {
                                    Console.WriteLine("THANK YOU");
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("PLEASE ENTER VALID OPTION");
                                    Console.ReadLine();
                                }
                            }
                        }
                    }
                }

                else if (chosenLanguage == "P")
                {

                    Console.Write("ABEG YOUR ENTER ACCOUNT NUMBER : ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    if (accountNumber != 554433221)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("ACCOUNT NUMBER NO CORRECT");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("ENTER  YOUR ATM PIN # : ");
                        pin = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        if (pin != 1984)
                        {
                            Console.WriteLine("YOU DEY WHINE ME NI, THE PIN NO CORRECT TRY AM AGAIN");
                            Console.ReadLine();
                        }
                        else if (pin == 1984)
                        {
                            while (true)
                            {
                                Console.WriteLine("=================================");
                                Console.WriteLine("WHICH KIND TRANSACTION YOU WAN RUN: 1, 2, 3\n");
                                Console.WriteLine("1. CHECK WETIN REMAIN\n");
                                Console.WriteLine("2. COMOT MONEY\n");
                                Console.WriteLine("3. TRANSFER MONI\n");
                                Console.WriteLine("4. SHUN THIS TRANSACTION \n");
                                Console.Write("RUN TRANSACTION : ");
                                option = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                if (option == 1)
                                {
                                    Console.WriteLine("ACCOUNT NUMBER : " + accountNumber);
                                    Console.WriteLine("ACCOUNT NAME : " + userName);
                                    Console.WriteLine("BALANCE : N " + balance);
                                    Console.WriteLine("THANK YOU");
                                    Console.ReadLine();
                                }
                                else if (option == 2)
                                {
                                    Console.Write("HOW MUCH YOU WAN COMOT FROM YOUR ACCOUNT : ");
                                    withdrawAmount = Convert.ToDouble(Console.ReadLine());
                                    if (withdrawAmount > 10000.00)
                                    {

                                        Console.WriteLine("OMO, NA 10,000.00 BE THE HIGHEST WEY YOU FIT COMOT");
                                        Console.WriteLine("THIS NA YOUR REMAINING BALANCE: N " + balance);
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        balance = balance - withdrawAmount;
                                        Console.WriteLine("THIS NA YOUR REMAINING BALANCE: N " + balance);
                                        Console.WriteLine("THANK YOU");
                                        Console.ReadLine();
                                    }
                                }
                                else if (option == 3)
                                {
                                    Console.WriteLine("ENTER AMOUNT TO TRANSFER : ");
                                    transferAmount = Convert.ToDouble(Console.ReadLine());
                                    if (transferAmount > 10000.00)
                                    {

                                        Console.WriteLine("SORRY, TRANSFER AMOUNT IS 10,000.00 MAXIMUM ONLY");
                                        Console.WriteLine("THIS IS YOUR REMAINING BALANCE: N " + balance);
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        balance = balance - transferAmount;
                                        Console.WriteLine("THIS IS YOUR REMAINING BALANCE: N " + balance);
                                        Console.WriteLine("THANK YOU");
                                        Console.ReadLine();
                                    }
                                }
                                else if (option == 4)
                                {
                                    Console.WriteLine("THANK YOU");
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("PLEASE ENTER VALID OPTION");
                                    Console.ReadLine();
                                }
                            }
                        }
                    }
                }

                else if (chosenLanguage == "I")
                {
                    Console.Write("tinye nomba akauntu : ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    if (accountNumber != 554433221)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Nomba akauntụ ezighi ezi ");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("tinye pin akauntu# : ");
                        pin = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        if (pin != 1984)
                        {
                            Console.WriteLine("Nomba Pin ezighi ezi biko nwaa ozo");
                            Console.ReadLine();
                        }
                        else if (pin == 1984)
                        {
                            while (true)
                            {
                                Console.WriteLine("=================================");
                                Console.WriteLine("Horo azumahia: 1, 2, 3\n");
                                Console.WriteLine("1. Juo ase\n");
                                Console.WriteLine("2. Ikwusi\n");
                                Console.WriteLine("3. Nyefee Ego");
                                Console.WriteLine("4. Mmemme opupu \n");
                                Console.Write("Horo azumahia : ");
                                option = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                if (option == 1)
                                {
                                    Console.WriteLine("Nomba akauntu : " + accountNumber);
                                    Console.WriteLine("Aha akauntu : " + userName);
                                    Console.WriteLine("Ego Balance : N " + balance);
                                    Console.WriteLine("Daalu");
                                    Console.ReadLine();
                                }
                                else if (option == 2)
                                {
                                    Console.Write("Tinye ego i ga-ewepu : ");
                                    withdrawAmount = Convert.ToDouble(Console.ReadLine());
                                    if (withdrawAmount > 10000.00)
                                    {

                                        Console.WriteLine("Ndo, iwepu ihe ruru 10,000.00 kacha naani");
                                        Console.WriteLine("Nke a bu nguzozi nke gi foduru: N " + balance);
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        balance = balance - withdrawAmount;
                                        Console.WriteLine("Nke a bu nguzozi nke gi foduru: N " + balance);
                                        Console.WriteLine("Daalu");
                                        Console.ReadLine();
                                    }
                                }
                                else if (option == 3)
                                {
                                    Console.WriteLine("Tinye ego iji nyefee : ");
                                    transferAmount = Convert.ToDouble(Console.ReadLine());
                                    if (transferAmount > 10000.00)
                                    {

                                        Console.WriteLine("Ndo, ego mbufe bụ 10,000.00 kacha naanị");
                                        Console.WriteLine("Nke a bu nguzozi nke gi foduru: N " + balance);
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        balance = balance - transferAmount;
                                        Console.WriteLine("Nke a bu nguzozi nke gi foduru: N " + balance);
                                        Console.WriteLine("Daalu");
                                        Console.ReadLine();
                                    }
                                }
                                else if (option == 4)
                                {
                                    Console.WriteLine("Daalu");
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Biko tinye ezigbo nhoro");
                                    Console.ReadLine();
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("error Occured:" + ex.Message);
                
            }
        }


    }
}

