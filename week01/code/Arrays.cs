public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {

        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //return []; // replace this return statement with your own
        //Solution Steps:
        // Step 1: create a new array of doubles with the size of 'length'
        double[] multiples = new double[length];
        // Step 2: use a for loop to iterate from 0 to length - 1
        for (int i = 0; i < length; i++)
        {
            // Step 3: inside the loop, calculate the multiple by multiplying 'number' with (index + 1)
            multiples[i] = number * (i + 1);  // (i+1) because we start with the first multiple
        }
        // Step 4: after the loop, return the filled array
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Identify how many items need to be moved from the end of the list
        int startIndex = data.Count - amount;

        // Step 2: Use GetRange to extract the last 'amount' values into a new list
        List<int> toMove = data.GetRange(startIndex, amount);

        // Step 3: Remove those last 'amount' values from the original list
        data.RemoveRange(startIndex, amount);

        // Step 4: Insert the extracted values at the beginning of the original list
        data.InsertRange(0, toMove);

    }
}
