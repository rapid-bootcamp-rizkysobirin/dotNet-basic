using DataTypes.CustomType;
using DataTypes.Inheritance;
using DataTypes.ObjectType;
using DataTypes.OOP;
using DataTypes.PolyType;
using System;
namespace DataTypes
{

    public struct Coords
    {
        public int x, y;
        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public override string ToString()
        {
            //     tulisan "Cord" gk ditulis gpp
            return "Coord ("+ x +","+ y +")";
        }
    }

    public class MainDataType
    {
        public static void Main()
        {
            //SampleEnum();
            //SampleClass();
            //BankAccountSample();
            //GiftCardAccountSample();
            //InterestEarningAccountsample();
            //LineOfCreditAccountSample();

            //LineOfCreditAccountSample();
            //InterestEarningAccountsample();

            //SampleObject();
            //SamplePolymorphism(); 
            //jd gini
            //SampleClassImplement.InterfaceImplement();
            Shape.SamplePolymorphism();
        }


        //ini dipindah di file shape.cs
        #region Polimorphism
        //public static void SamplePolymorphism()
        //{
        //    // Polymorphism at work #1: a Rectangle, Triangle and Circle
        //    // can all be used wherever a Shape is expected. No cast is
        //    // required because an implicit conversion exists from a derived
        //    // class to its base class.
        //    var shapes = new List<Shape>
        //    {
        //        new Rectangle(),
        //        new Triangle(),
        //        new Circle()
        //    };

        //    // Polymorphism at work #2: the virtual method Draw is
        //    // invoked on each of the derived classes, not the base class.
        //    foreach (var shape in shapes)
        //    {
        //        shape.Draw();
        //    }
        //    /* Output:
        //        Drawing a rectangle
        //        Performing base class drawing tasks
        //        Drawing a triangle
        //        Performing base class drawing tasks
        //        Drawing a circle
        //        Performing base class drawing tasks
        //    */
        //}

        #endregion

        #region Sample Inheritance
        public static void SampleInheritance()
        {
            // Create an instance of WorkItem by using the constructor in the
            // base class that takes three arguments.
            WorkItem item = new WorkItem("Fix Bugs",
                                        "Fix all bugs in my code branch",
                                        new TimeSpan(3, 4, 0, 0));

            // Create an instance of ChangeRequest by using the constructor in
            // the derived class that takes four arguments.
            ChangeRequest change = new ChangeRequest("Change Base Class Design",
                                                    "Add members to the class",
                                                    new TimeSpan(4, 0, 0),
                                                    1);

            // Use the ToString method defined in WorkItem.
            Console.WriteLine(item.ToString());

            // Use the inherited Update method to change the title of the
            // ChangeRequest object.
            change.Update("Change the Design of the Base Class",
                new TimeSpan(4, 0, 0));

            // ChangeRequest inherits WorkItem's override of ToString.
            Console.WriteLine(change.ToString());
            /* Output:
                1 - Fix Bugs
                2 - Change the Design of the Base Class
            */


        }

        #endregion

        #region Sample Object
        public static void SampleObject()
        {
            //     object         konstruktor
            Person person1 = new Person("Leopold", 6);
            Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);

            // Declare new person, assign person1 to it.
            Person person2 = person1;

            // Change the name of person2, and person1 also changes.
            person2.Name = "Molly";
            person2.Age = 16;

            Console.WriteLine("person2 Name = {0} Age = {1}", person2.Name, person2.Age);
            Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);

            Person person3 = new Person("Obi",90);
            Console.WriteLine("person3 Name = {0} Age = {1}", person3.Name, person3.Age);

            Product productA = new Product("Garem", 5000, "Bumbu Dapur");
            Console.WriteLine("{0} adalah {2} seharga {1}", productA.Name, productA.Price, productA.Category);

        }
        #endregion

        #region Sample LineofCredit
        //dapat memiliki saldo negatif, tetapi bila ada saldo, ada beban bunga setiap bulan.
        public static void LineOfCreditAccountSample()
        {
            var lineOfCredit = new LineOfCreditAccount("line of credit", 0);
            // How much is too much to borrow?
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransactions();
            Console.WriteLine(lineOfCredit.GetAccountHistory());
        }
        #endregion

        #region Sample GiftCard
        //diisi ulang sekali pada awal setiap bulan.
        public static void GiftCardAccountSample()
        {
            var giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
            giftCard.PerformMonthEndTransactions();
            // can make additional deposits:
            giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            Console.WriteLine(giftCard.GetAccountHistory());
        }
        #endregion

        #region Sample Interest Earning Account Sample
        //bunga pada akhir setiap bulan
        public static void InterestEarningAccountsample()
        {
            var savings = new InterestEarningAccount("savings account", 10000);
            savings.MakeDeposit(750, DateTime.Now, "save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            savings.PerformMonthEndTransactions();
            Console.WriteLine(savings.GetAccountHistory());
        }
        #endregion

        #region Sample Transaction BankAccount
        public static void TransactionBankAccount()
        {
            var account = new BankAccount("CF", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            // Test for a negative balance.
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            // Test that the initial balances must be positive.
            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }

            

            
        }

        #endregion

        #region Sample BankAccount
        public static void BankAccountSample()
        {
            var account = new BankAccount("AB", 100000000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            var account2 = new BankAccount("CD", 100000030);
            Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance.");

            var account3 = new BankAccount("EF", 100000700);
            Console.WriteLine($"Account {account3.Number} was created for {account3.Owner} with {account3.Balance} initial balance.");
        }
        #endregion

        #region Sample Class
        public static void SampleClass()
        {
            SampleClass sampleClass;//hasil error
            //Console.WriteLine("Sample class value: {0}", sampleClass.ToString());

            sampleClass = new SampleClass();//hasil default 0
            Console.WriteLine("After call constructor");
            Console.WriteLine("Sample class value: {0}", sampleClass.ToString());

            sampleClass = new SampleClass(9,8);
            Console.WriteLine("After call constructor with params");
            Console.WriteLine("Sample class value: {0}", sampleClass.ToString());

        }

        #endregion

        #region Sample Enum
        public static void SampleEnum()
        {
            Type weekDays = typeof(EnumDays);
            foreach (var item in Enum.GetNames(weekDays))
            {
                Console.WriteLine("Days: {0}", item);
            }

            Type fieldModel = typeof(EnumFileMode);
            foreach (var item in Enum.GetNames(fieldModel))
            {
                Console.WriteLine("FieldMode : {0}", item);
            }

            Colors myColors = Colors.Red | Colors.Blue | Colors.Yellow;
            Console.WriteLine();
            Console.WriteLine("myColors holds a combination of colors. Namely: {0}", myColors);
            Console.WriteLine("Color Red: {0}, GetName: {1}", Colors.Red, Enum.GetName(Colors.Red));

            Console.WriteLine("Status Approved: {0}, Names: {1}", ApprovalStep.Approved, Enum.GetName(ApprovalStep.Approved));

        }
        #endregion

        #region Sample Coord
        public static void SampleCoord()
        {
            Coords point1 = new Coords(2, 5);
            Console.WriteLine("Point 1: " + point1);

            Coords point2 = new Coords(5, 5);
            Console.WriteLine("Point 2: " + point2);
        }
        #endregion

        #region Sample Data Type
        public static void SampleDataType()
        {
            // Declaration with initializers (four examples):
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 13, 15, 18, 21 };
            // ini adalah linQ
            var query = from item in source
                        where item <= limit
                        select item;
            Console.WriteLine("Query Result :" + query);
            foreach (var item in query)
            {
                Console.WriteLine("item value: " + item);
            }

            var query2 = from item in source
                         where item % 2 == 1
                         select item;
            Console.WriteLine("Write item with odd");
            foreach (var item in query2)
            {
                Console.WriteLine("item value: " + item);
            }

            var query3 = from item in source
                         where item % 2 == 0
                         select item;
            Console.WriteLine("Write item with even");
            foreach (var item in query3)
            {
                Console.WriteLine("item value: " + item);
            }

            var query4 = from item in source
                         where item % 3 == 0
                         select item;
            Console.WriteLine("Write item with multiple 3");
            foreach (var item in query4)
            {
                Console.WriteLine("item value: " + item);
            }
        }
        #endregion
    }
}


