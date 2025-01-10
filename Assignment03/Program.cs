namespace Assignment03
{
    static class Program
    {
        static int boxingCount = 0;
        static int unboxingCount = 0;

        static void Main(string[] args)
        {
            try
            {
                // Create HireDate instances
                HireDate hireDate1 = new HireDate(1, 1, 2020);
                HireDate hireDate2 = new HireDate(15, 6, 2021);
                HireDate hireDate3 = new HireDate(10, 12, 2022);

                // Create Employee array with three Employees
                Employee[] EmpArr = new Employee[3];

                EmpArr[0] = new Employee(1, "Alice", SecurityLevel.DBA, 85000, hireDate1, 'F');
                EmpArr[1] = new Employee(2, "Bob", SecurityLevel.Guest, 45000, hireDate2, 'M');
                EmpArr[2] = new Employee(3, "Charlie", SecurityLevel.SecurityOfficer, 95000, hireDate3, 'M');

                // Display original Employee array
                Console.WriteLine("Original Employee List:");
                foreach (var employee in EmpArr)
                {
                    Console.WriteLine(employee);
                }

                // Sort the Employee array based on HireDate
                Array.Sort(EmpArr, (emp1, emp2) =>
                {
                    // Boxing and Unboxing count tracking
                    object boxedEmp1 = emp1.HireDate;
                    object boxedEmp2 = emp2.HireDate;
                    boxingCount += 2;

                    HireDate hireDate1 = (HireDate)boxedEmp1;
                    HireDate hireDate2 = (HireDate)boxedEmp2;
                    unboxingCount += 2;

                    return hireDate1.CompareTo(hireDate2);
                });

                // Display sorted Employee array
                Console.WriteLine("\nSorted Employee List by Hire Date:");
                foreach (var employee in EmpArr)
                {
                    Console.WriteLine(employee);
                }

                // Output the boxing and unboxing counts
                Console.WriteLine($"\nBoxing Count: {boxingCount}");
                Console.WriteLine($"Unboxing Count: {unboxingCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Create an instance of EBook
            EBook ebook1 = new EBook("C# Programming", "Abdullah T.Hosni", "123-456-789", 9.5);
            // Create an instance of PrintedBook
            PrintedBook printedBook1 = new PrintedBook("The Great Gatsby", "F. Scott Fitzgerald", "987-654-321", 218);

            // Display the information of both books
            Console.WriteLine("EBook Info:");
            ebook1.DisplayInfo();

            Console.WriteLine("\nPrinted Book Info:");
            printedBook1.DisplayInfo();
        }
    }



}
